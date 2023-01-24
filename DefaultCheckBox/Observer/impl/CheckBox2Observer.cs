using System.Windows.Forms;

namespace DefaultCheckBox.Observer.impl
{
    public class CheckBox2Observer : StateObserver
    {
        private StateDefaultImpl _state;
        private System.Windows.Forms.CheckBox _checkBox;
        private int observValue;
        // 이게 맞나? 코드 결합성이 너무 심한거 같은데...

        public CheckBox2Observer(StateDefaultImpl state, CheckBox checkBox)
        {
            _state = state;
            _checkBox = checkBox;
            state.registerObserver(this);
        }

        public void update()
        {
            _checkBox 
        }
    }
}