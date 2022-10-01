namespace NameEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    System.Windows.Forms.MessageBox.Show(files.Length.ToString() + " tane dosya bulundu!" , "Mesaj");

                    textBox1.Text = fbd.SelectedPath;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(textBox1.Text.ToString());
                FileInfo[] infos = d.GetFiles();
                foreach (FileInfo f in infos)
                {
                    File.Move(f.FullName, f.FullName.Replace(textBox2.Text, ""));
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "Hata!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                DirectoryInfo d = new DirectoryInfo(textBox1.Text.ToString());
                FileInfo[] infos = d.GetFiles();
                foreach (FileInfo f in infos)
                {
                    var tfile = TagLib.File.Create(f.ToString());
                    tfile.Tag.AlbumArtists = new string[] { tfile.Tag.Performers[0] };
                    tfile.Save();
                }
                
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "Hata!");
            }
        }
    }
}