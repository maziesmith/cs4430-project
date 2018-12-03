using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollMgmt.Utils {
    class ComboBoxItem {
        public string Text { get; set; }
        public int Value { get; set; }

        public ComboBoxItem(string Text, int Value) {
            this.Text = Text;
            this.Value = Value;
        }

        public override string ToString() {
            return Text;
        }
    }
}
