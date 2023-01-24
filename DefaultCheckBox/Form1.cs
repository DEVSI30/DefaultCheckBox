using System.Windows.Forms;
using DefaultCheckBox.Observer.impl;

namespace DefaultCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StateDefaultImpl state = new StateDefaultImpl();

            DefaultCheckBoxObserver defaultCheckBoxObserver = new DefaultCheckBoxObserver(state, checkBox1);
            ValueTextBoxObserver valueTextBoxObserver = new ValueTextBoxObserver(state, textBox1);
            CheckBox2Observer checkBox2Observer = new CheckBox2Observer(state, checkBox2);
            CheckBox3Observer checkBox3Observer = new CheckBox3Observer(state, checkBox3);
            StateTextBoxObserver stateTextBoxObserver = new StateTextBoxObserver(state, txtState);
            state.notifyObservers(); // init
        }
    }
}