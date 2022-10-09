using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Basic_Queuing_Cashier
{
    public partial class CashierWindowQueue : Form
    {
        public CashierWindowQueue()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = (1 * 1000); 
            timer.Tick += new EventHandler(btnRefresh_Click); 
            timer.Start();
        }
        
        Boolean FormOpen = false;
        CustomerView customerView = new CustomerView();
        FormCollection AllForms = Application.OpenForms;
        Form newForm = new Form();
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);

        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }
        public delegate void PassControl(object sender);
        public PassControl passControl;

        public void OpenCashier()
        {
            if (FormOpen == false)
            {
                CashierWindowQueue cashierWindowQueue = new CashierWindowQueue();
                cashierWindowQueue.Visible = true;
                FormOpen = true;
            }
        }
        public void Next()
        {
            foreach (Form form in AllForms)
            {
                if (form.Name == "CustomerView")
                {
                    newForm = form;
                    FormOpen = true;
                }
            }
            if (FormOpen == true)
            {
                if (passControl != null)
                {
                    customerView.CurrentServe.Text = CashierClass.CashierQueue.Peek();
                    CashierClass.CashierQueue.Dequeue();
                    passControl(customerView.CurrentServe);
                }
                
            }
            else
            {
                customerView.ShowDialog();
                customerView.CurrentServe.Text = CashierClass.CashierQueue.Peek().ToString();
                CashierClass.CashierQueue.Dequeue();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            Next();
            
        }
    }
}
