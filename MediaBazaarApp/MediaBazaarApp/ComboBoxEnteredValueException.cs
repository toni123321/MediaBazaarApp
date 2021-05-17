using System;

namespace MediaBazaarApp
{
    class ComboBoxEnteredValueException : Exception
    {
        public ComboBoxEnteredValueException() : base($"Please, make sure to choose an existing value from the combo box.\nTyping values in the combo box is not possible.")
        {

        }

    }
}
