using System.Reflection;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] tablica = sortowanie.Konwertuj(tb.Text);
            //sortowanie.Babelkowe(tablica);
           
            var metoda = (MethodInfo)cb.SelectedItem;
            metoda.Invoke(null, new object[] { tablica });
            MessageBox.Show(string.Join(", ", tablica));
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            var metody = typeof(sortowanie).GetMethods().Where(m => m.GetParameters().Length == 1 && m.GetParameters().First().ParameterType == typeof(int[]) && m.ReturnType == typeof(void) && m.IsStatic).ToArray();
            cb.DataSource = metody;
            cb.DisplayMember = "Name";
            
        }

    }
}