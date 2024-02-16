using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIAutomationTestingExample {
    public partial class CustomersForm : DevExpress.XtraEditors.XtraForm {
        public CustomersForm() {
            InitializeComponent();

            ObservableCollection<Customer> customers = new ObservableCollection<Customer>();
            for (int i = 1; i < 30; i++) {
                customers.Add(new Customer() { ID = i, Name = "Customer" + i });
            }
            customersGrid.DataSource = customers;
        }

        HashSet<Customer> modifiedItems = new HashSet<Customer>();
        void customersGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
            if (e.Column.FieldName != "IsModified")
                return;
            Customer customer = e.Row as Customer;
            if (customer != null && modifiedItems.Contains(customer)) {
                e.Value = true;

            }
        }

        void customersGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e) {
            modifiedItems.Add((Customer)customersGridView.GetRow(e.RowHandle));
        }
    }

    public class Customer {
        public int ID {
            get;
            set;
        }

        public string Name {
            get;
            set;
        }
    }
}
