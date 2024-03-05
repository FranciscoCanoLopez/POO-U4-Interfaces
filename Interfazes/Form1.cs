using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Interfazes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDOG_Click(object sender, EventArgs e)
        {
            IAnimal dog = new Dog();
            MessageBox.Show("The dog says: " + dog.MakeSound());
        }

        private void btnCAT_Click(object sender, EventArgs e)
        {
            IAnimal cat = new Cat();
            MessageBox.Show("The cat says: " + cat.MakeSound());
        }
    }
}
