///<summary>
/// The point of this file is to display the rental form.
///
/// Author: Kade Levy
/// Version: 4/11/2026
/// </summary>

using Furniture4AllApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture4AllApp.Views
{
    /// <summary>
    /// Represents a rental form where employees can manage rentals for members. 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class RentalForm : Form
    {
        private Employee loggedInEmployee;
        private Member currentMember;
        private List<CartItem> cartItems = new List<CartItem>();

        public RentalForm(Employee employee, Member member)
        {
            InitializeComponent();
            loggedInEmployee = employee;
            currentMember = member;
        }
    }
}
