using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Repository;
using   TmTech_v1.Model;


namespace TmTech_v1.View.UCcontrol
{
    public partial class StaftProfile : UserControl
    {
        private int _idStaff = 1;
        public StaftProfile( )
        {
            InitializeComponent();
         //   _idStaff = idstaft;
            _idStaff = 1;
        }

        private void StaftProfile_Load(object sender, EventArgs e)
        {

            if (_idStaff < 1)
                return;

            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    var stafter = uow.StaffRepository.Find(_idStaff);

                    if (stafter != null)
                    {
                        txtStaftName.Text = stafter.Name;
                        txtID.Text = stafter.Id.ToString();
                        txtPhone.Text = stafter.Phone1;
                        txtEmail.Text = stafter.Email;
                        if (stafter.Sex == true)
                        {
                            cboSex.SelectedIndex = 0;

                        }
                        else cboSex.SelectedIndex = 1;
                    }

                }

            }
            catch (Exception)
            {

                return;
            }
           
        }

        
        

    }
}
