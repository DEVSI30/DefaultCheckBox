using System;
using System.Windows.Forms;

namespace DefaultCheckBox.Observer.impl
{
    public class CheckBox2Observer : StateObserver
    {
        private StateDefaultImpl _state;
        private System.Windows.Forms.CheckBox _checkBox;

        public CheckBox2Observer(StateDefaultImpl state, CheckBox checkBox)
        {
            _state = state;
            state.registerObserver(this);
            _checkBox = checkBox;
            _checkBox.CheckedChanged += new EventHandler(chekcedChanged);
        }

        public void update()
        {
            _checkBox.Checked = _state.ChkBox2Checked;
        }

        private void chekcedChanged(object sender, EventArgs args)
        {
            _state.ChkBox2Checked = _checkBox.Checked;
        }
    }
}