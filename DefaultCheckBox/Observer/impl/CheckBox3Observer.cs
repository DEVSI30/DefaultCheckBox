using System;
using System.Windows.Forms;

namespace DefaultCheckBox.Observer.impl
{
    public class CheckBox3Observer : StateObserver
    {
        private StateDefaultImpl _state;
        private System.Windows.Forms.CheckBox _checkBox;

        public CheckBox3Observer(StateDefaultImpl state, CheckBox checkBox)
        {
            _state = state;
            state.registerObserver(this);
            _checkBox = checkBox;
            _checkBox.CheckedChanged += new EventHandler(chekcedChanged);
        }

        public void update()
        {
            _checkBox.Checked = _state.ChkBox3Checked;
        }
        
        private void chekcedChanged(object sender, EventArgs args)
        {
            _state.ChkBox3Checked = _checkBox.Checked;
        }
    }
}