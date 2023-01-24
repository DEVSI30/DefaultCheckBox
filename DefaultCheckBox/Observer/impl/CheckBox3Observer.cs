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
            _checkBox = checkBox;
            state.registerObserver(this);
        }

        public void update()
        {
            _checkBox.Checked = _state.ChkBox2Checked;
        }
    }
}