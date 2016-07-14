using CG.Web.MegaApiClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MultiMega_Client
{
    public partial class FormMultiMegaClient : Form
    {
        formgestao formgestao;
        MegaApiClient client;
        INode present_node;
        private Thread t;
        string tipo;

        public FormMultiMegaClient()
        {
            InitializeComponent();
            formgestao = new formgestao();
            tipo = "";
            client = new MegaApiClient();
            client.Login("c1048111@trbvn.com", "contacommaiscoisas2016");
            var nodes = client.GetNodes().ToList();

            //Get root id

            present_node = nodes.ElementAt(0);
        }

        private void bt_manageaccounts_Click(object sender, EventArgs e)
        {
            formgestao.ShowDialog();
        }

        private void populateList(INode selected_node)
        {
            listView1.Invoke(new Action(() => listView1.Clear()));

            var nodes = client.GetNodes(selected_node).ToList();

            foreach (INode elemento in nodes)
            {
                if (elemento.ParentId == selected_node.Id)
                {
                    string nome = elemento.Name.ToString();
                    if (elemento.Type == NodeType.Directory)
                    {
                        nome = "<DIR>" + nome;
                    }
                    listView1.Invoke(new Action(() => listView1.Items.Add(nome)));
                }
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //get node selected

            var nodes = client.GetNodes();

            INode selected_node;

            if (listView1.SelectedItems[0].Text.Contains("<DIR>"))
            {
                selected_node = nodes.Single(n => n.Name == listView1.SelectedItems[0].Text.Substring(5));
            }
            else
            {
                selected_node = nodes.Single(n => n.Name == listView1.SelectedItems[0].Text);
            }

            if (selected_node.Type == NodeType.Directory)
            {
                present_node = selected_node;
                populateList(present_node);
            }
            else if (selected_node.Type == NodeType.File)
            {
                bt_downloadfile_Click(sender, e);
            }
        }

        private void bt_parentfolder_Click(object sender, EventArgs e)
        {
            var nodes = client.GetNodes();

            INode reference_node;

            if (listView1.Items[0].Text.Contains("<DIR>"))
            {
                reference_node = nodes.Single(n => n.Name == listView1.Items[0].Text.Substring(5));
            }
            else
            {
                reference_node = nodes.Single(n => n.Name == listView1.Items[0].Text);
            }

            INode parent_selected_node = nodes.Single(n => n.Id == reference_node.ParentId);

            //Precisamos de popular com o parent do parent
            present_node = nodes.Single(n => n.Id == parent_selected_node.ParentId);

            populateList(present_node);
        }

        public void UploadWithProgression()
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            DialogResult resultado = DialogResult.None;
            listView1.Invoke(new Action(() => resultado = openfiledialog.ShowDialog()));

            string filePath = openfiledialog.FileName;

            if (resultado == DialogResult.OK)
            {
                using (var stream = new ProgressionStream(new FileStream(filePath, FileMode.Open), this.PrintProgression))
                {
                    client.Upload(stream, Path.GetFileName(filePath), present_node);
                }
            }
            else
            {
                return;
            }
        }

        public void DownloadWithProgression(INode node)
        {
            SaveFileDialog savefiledialog = new SaveFileDialog();
            DialogResult resultado = DialogResult.None;
            savefiledialog.FileName = node.Name.ToString();
            listView1.Invoke(new Action(() => resultado = savefiledialog.ShowDialog()));

            string filePath = savefiledialog.FileName;

            if (resultado == DialogResult.OK)
            {
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    using (var downloadStream = new ProgressionStream(client.Download(node), this.PrintProgression))
                    {
                        downloadStream.CopyTo(fileStream);
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void PrintProgression(double progression)
        {
            Console.WriteLine(progression);
            if (tipo == "download")
                lbl_status.Text = "Download em " + ((int)progression).ToString() + "%";
            else if (tipo == "upload")
                lbl_status.Text = "Upload em " + ((int)progression).ToString() + "%";
            else
                lbl_status.Text = "No activity";
        }

        public class ProgressionStream : Stream
        {
            public delegate void ProgressionHandler(double progression);

            private Stream _sourceStream;
            private ProgressionHandler _progressionHandler;

            public ProgressionStream(Stream sourceStream, ProgressionHandler progressionHandler)
            {
                this._sourceStream = sourceStream;
                this._progressionHandler = progressionHandler;
            }

            public override int Read(byte[] array, int offset, int count)
            {
                this._progressionHandler(this.Position / (double)this.Length * 100);

                return this._sourceStream.Read(array, offset, count);
            }

            public override bool CanRead
            {
                get
                {
                    return this._sourceStream.CanRead;
                }
            }

            public override bool CanSeek
            {
                get
                {
                    return this._sourceStream.CanSeek;
                }
            }

            public override bool CanWrite
            {
                get
                {
                    return this._sourceStream.CanWrite;
                }
            }

            public override long Length
            {
                get
                {
                    return this._sourceStream.Length;
                }
            }

            public override long Position
            {
                get
                {
                    return this._sourceStream.Position;
                }

                set
                {
                    this._sourceStream.Position = value;
                }
            }

            public override void Flush()
            {
                this._sourceStream.Flush();
            }

            public override long Seek(long offset, SeekOrigin origin)
            {
                return this._sourceStream.Seek(offset, origin);
            }

            public override void SetLength(long value)
            {
                this._sourceStream.SetLength(value);
            }

            public override void Write(byte[] buffer, int offset, int count)
            {
                this._sourceStream.Write(buffer, offset, count);
            }
        }

        private void bt_downloadfile_Click(object sender, EventArgs e)
        {
            t = new Thread(downloadFileMega);
            t.Start();
        }
        private void downloadFileMega()
        {
            tipo = "download";
            var nodes = client.GetNodes();

            INode selected_node = null;

            bool resultado = false;
            string selectedItem = "";

            listView1.Invoke(new Action(() => resultado = listView1.SelectedItems[0].Text.Contains("<DIR>")));
            listView1.Invoke(new Action(() => selectedItem = listView1.SelectedItems[0].Text));


            if (resultado == true)
            {
                listView1.Invoke(new Action(() => selected_node = nodes.Single(n => n.Name == selectedItem.Substring(5))));
            }
            else
            {
                listView1.Invoke(new Action(() => selected_node = nodes.Single(n => n.Name == selectedItem)));
            }

            if (selected_node.Type == NodeType.File)
            {
                DownloadWithProgression(selected_node);
            }
            lbl_status.Text = "No Activity";
            tipo = "";
            populateList(present_node);
        }
        private void uploadFileMega()
        {
            tipo = "upload";
            UploadWithProgression();
            lbl_status.Text = "No Activity";
            tipo = "";
            populateList(present_node);
        }

        private void bt_uploadfile_Click(object sender, EventArgs e)
        {
            t = new Thread(uploadFileMega);
            t.Start();
        }

        private void FormMultiMegaClient_Load(object sender, EventArgs e)
        {
            populateList(present_node);
        }

        private void bt_deletefile_Click(object sender, EventArgs e)
        {
            var nodes = client.GetNodes();

            INode selected_node = null;

            bool resultado = false;
            string selectedItem = "";

            listView1.Invoke(new Action(() => resultado = listView1.SelectedItems[0].Text.Contains("<DIR>")));
            listView1.Invoke(new Action(() => selectedItem = listView1.SelectedItems[0].Text));


            if (resultado == true)
            {
                selected_node = nodes.Single(n => n.Name == selectedItem.Substring(5));
            }
            else
            {
                selected_node = nodes.Single(n => n.Name == selectedItem);
            }

            if (selected_node.Type == NodeType.File)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this file?", "MultiMega Client", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        client.Delete(selected_node, false);
                        MessageBox.Show("The file was deleted sucessfully!", "MultiMega Client");
                    }
                    catch
                    {
                        MessageBox.Show("An error occur when trying to delete this file!", "MultiMega Client");
                    }
                }
            }
            populateList(present_node);
        }

        private void bt_createfolder_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Interaction.InputBox("Please insert a name to the folder", "MultiMega Client", "");
                if (name != "")
                    client.CreateFolder(name, present_node);
            }
            catch
            {
                MessageBox.Show("An error occur when trying to create a folder!", "MultiMega Client");
            }
            populateList(present_node);
        }

        private void bt_deletefolder_Click(object sender, EventArgs e)
        {
            var nodes = client.GetNodes();

            INode selected_node = null;

            bool resultado = false;
            string selectedItem = "";

            listView1.Invoke(new Action(() => resultado = listView1.SelectedItems[0].Text.Contains("<DIR>")));
            listView1.Invoke(new Action(() => selectedItem = listView1.SelectedItems[0].Text));


            if (resultado == true)
            {
                selected_node = nodes.Single(n => n.Name == selectedItem.Substring(5));
            }
            else
            {
                selected_node = nodes.Single(n => n.Name == selectedItem);
            }

            if (selected_node.Type == NodeType.Directory)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this folder?", "MultiMega Client", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {                        
                        client.Delete(selected_node, false);
                        MessageBox.Show("The folder was deleted sucessfully!", "MultiMega Client");
                    }
                    catch
                    {
                        MessageBox.Show("An error occur when trying to delete this file!", "MultiMega Client");
                    }
                }
            }
            populateList(present_node);
        }
    }
}
