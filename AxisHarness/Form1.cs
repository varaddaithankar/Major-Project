using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AxisLib;

namespace AxisHarness
{
    public partial class Form1 : Form
    {
        private AxisInterface m_AxisIF1;
        private AxisInterface m_AxisIF2;
        private AxisInterface m_AxisIF3;
        string m_IPAddress = "";
        bool m_UseComboBox;

        public Form1()
        {
            InitializeComponent();
            m_AxisIF1 = new AxisInterface();
            m_AxisIF2 = new AxisInterface();
            m_AxisIF3 = new AxisInterface();
            m_AxisIF1.ServerClosed += new _IAxisInterfaceEvents_ServerClosedEventHandler(m_AxisIF1_ServerClosed);
            m_AxisIF2.ServerClosed += new _IAxisInterfaceEvents_ServerClosedEventHandler(m_AxisIF2_ServerClosed);
            m_AxisIF3.ServerClosed += new _IAxisInterfaceEvents_ServerClosedEventHandler(m_AxisIF3_ServerClosed);
            cmbParameterID.DataSource = null;
            cmbParameterID.DataSource = System.Enum.GetValues(typeof(E_SERCOS_ID));
            grpSelectMode.Enabled = false;

            string[] args = Environment.GetCommandLineArgs();

            if (args.Length == 2)
            {
                string controllerIP = args[1];
                controllerIP = controllerIP.Remove(0, 12);
                m_IPAddress = controllerIP;
                IpList.Visible = false;

                m_UseComboBox = false;

            }
            else
            {
                m_UseComboBox = true;
                clsIPAddress.GetAddresses(ref IpList);
                IpList.Visible = true;
   
            }
            
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_UseComboBox)
                {
                    m_IPAddress = IpList.Text;
                }
                m_AxisIF1.Connect(m_IPAddress, txtAxis1.Text);
                m_AxisIF2.Connect(m_IPAddress, txtAxis2.Text);
                m_AxisIF3.Connect(m_IPAddress, txtAxis3.Text);
                clsIPAddress.SetIPValue(m_IPAddress);
                cmdConnect.BackColor = Color.FromArgb(0, 192, 0);
                bigLabel.Text = m_AxisIF1.AxisName.ToString();
            }
            catch
            {
                MessageBox.Show("Could not connect to controller: " + m_IPAddress);
            }
        }

        private void m_AxisIF1_ServerClosed()
        {
                        bigLabel.Text += "The Controller Has Closed the Connection\n";
        }
        private void m_AxisIF2_ServerClosed()
        {
                        bigLabel.Text += "The Controller Has Closed the Connection\n";
        }
        private void m_AxisIF3_ServerClosed()
        {
                        bigLabel.Text += "The Controller Has Closed the Connection\n";
        }

        private void cmdXYZ_CheckedChanged(object sender, EventArgs e)
        {
            txtAxis1.Text = "X";
            txtAxis2.Text = "Y";
            txtAxis3.Text = "Z";
        }

        private void cmdPQR_CheckedChanged(object sender, EventArgs e)
        {
            txtAxis1.Text = "P";
            txtAxis2.Text = "Q";
            txtAxis3.Text = "R";
        }

        private void cmdGet1_Click(object sender, EventArgs e)
        {
            try
            {
                string Param;
                EAxisReturnCode GetParamReturn = m_AxisIF1.GetParameter((E_SERCOS_ID)(cmbParameterID.SelectedItem), out Param);
                txtParam1.Text = Param;
                txtReturn1.Text = GetParamReturn.ToString();
                txtReturn2.Text = "";
                txtReturn3.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void cmdGet2_Click(object sender, EventArgs e)
        {
            try
            {
                string Param;
                EAxisReturnCode GetParamReturn = m_AxisIF2.GetParameter((E_SERCOS_ID)(cmbParameterID.SelectedItem), out Param);
                txtParam2.Text = Param;
                txtReturn1.Text = "";                
                txtReturn2.Text = GetParamReturn.ToString();
                txtReturn3.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void cmdGet3_Click(object sender, EventArgs e)
        {
            try
            {
                string Param;
                EAxisReturnCode GetParamReturn = m_AxisIF3.GetParameter((E_SERCOS_ID)(cmbParameterID.SelectedItem), out Param);
                txtParam3.Text = Param;
                txtReturn1.Text = "";
                txtReturn2.Text = "";
                txtReturn3.Text = GetParamReturn.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void cmdGetAll_Click(object sender, EventArgs e)
        {
            try
            {
                string Param1;
                string Param2;
                string Param3;
                EAxisReturnCode GetParamReturn1 = m_AxisIF1.GetParameter((E_SERCOS_ID)(cmbParameterID.SelectedItem), out Param1);
                txtParam1.Text = Param1;
                txtReturn1.Text = GetParamReturn1.ToString();
                EAxisReturnCode GetParamReturn2 = m_AxisIF2.GetParameter((E_SERCOS_ID)(cmbParameterID.SelectedItem), out Param2);
                txtParam2.Text = Param2;
                txtReturn2.Text = GetParamReturn2.ToString();
                EAxisReturnCode GetParamReturn3 = m_AxisIF3.GetParameter((E_SERCOS_ID)(cmbParameterID.SelectedItem), out Param3);
                txtParam3.Text = Param3;
                txtReturn3.Text = GetParamReturn3.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void cmdSet1_Click(object sender, EventArgs e)
        {
            try
            {
                EAxisReturnCode SetParamReturn = m_AxisIF1.SetParameter((E_SERCOS_ID)(cmbParameterID.SelectedItem), txtParam1.Text);
                txtReturn1.Text = SetParamReturn.ToString();
                txtReturn2.Text = "";
                txtReturn3.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void cmdSet2_Click(object sender, EventArgs e)
        {
            try
            {
                EAxisReturnCode SetParamReturn = m_AxisIF2.SetParameter((E_SERCOS_ID)(cmbParameterID.SelectedItem), txtParam2.Text);
                txtReturn1.Text = "";
                txtReturn2.Text = SetParamReturn.ToString();
                txtReturn3.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void cmdSet3_Click(object sender, EventArgs e)
        {
            try
            {
                EAxisReturnCode SetParamReturn = m_AxisIF3.SetParameter((E_SERCOS_ID)(cmbParameterID.SelectedItem), txtParam3.Text);
                txtReturn1.Text = "";
                txtReturn2.Text = "";
                txtReturn3.Text = SetParamReturn.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void cmdSetAll_Click(object sender, EventArgs e)
        {
            try
            {
                EAxisReturnCode SetParam1Return = m_AxisIF1.SetParameter((E_SERCOS_ID)(cmbParameterID.SelectedItem), txtParam1.Text);
                txtReturn1.Text = SetParam1Return.ToString();
                EAxisReturnCode SetParam2Return = m_AxisIF2.SetParameter((E_SERCOS_ID)(cmbParameterID.SelectedItem), txtParam2.Text);
                txtReturn2.Text = SetParam2Return.ToString();
                EAxisReturnCode SetParam3Return = m_AxisIF3.SetParameter((E_SERCOS_ID)(cmbParameterID.SelectedItem), txtParam3.Text);
                txtReturn3.Text = SetParam3Return.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            try
            {
                EAxisReturnCode ExecuteReturn1 = m_AxisIF1.ExecuteProcedureCommand(E_SERCOS_ID.DRIVE_CONTROLLED_HOMING, E_PROCEDURE_CMD.CMD_ENABLE);
                txtReturn1.Text = ExecuteReturn1.ToString();
                EAxisReturnCode ExecuteReturn2 = m_AxisIF2.ExecuteProcedureCommand(E_SERCOS_ID.DRIVE_CONTROLLED_HOMING, E_PROCEDURE_CMD.CMD_ENABLE);
                txtReturn2.Text = ExecuteReturn2.ToString();
                EAxisReturnCode ExecuteReturn3 = m_AxisIF3.ExecuteProcedureCommand(E_SERCOS_ID.DRIVE_CONTROLLED_HOMING, E_PROCEDURE_CMD.CMD_ENABLE);
                txtReturn3.Text = ExecuteReturn3.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            try
            {
                EAxisReturnCode ExecuteReturn1 = m_AxisIF1.ExecuteProcedureCommand(E_SERCOS_ID.RESET_CLASS1_DIAGS, E_PROCEDURE_CMD.CMD_ENABLE);
                txtReturn1.Text = ExecuteReturn1.ToString();
                EAxisReturnCode ExecuteReturn2 = m_AxisIF2.ExecuteProcedureCommand(E_SERCOS_ID.RESET_CLASS1_DIAGS, E_PROCEDURE_CMD.CMD_ENABLE);
                txtReturn1.Text = ExecuteReturn2.ToString();
                EAxisReturnCode ExecuteReturn3 = m_AxisIF3.ExecuteProcedureCommand(E_SERCOS_ID.RESET_CLASS1_DIAGS, E_PROCEDURE_CMD.CMD_ENABLE);
                txtReturn1.Text = ExecuteReturn3.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void cmdEnable_Click(object sender, EventArgs e)
        {
            try
            {
                EAxisReturnCode ret1 = m_AxisIF1.EnableDrive(true);
                txtReturn1.Text = ret1.ToString();
                EAxisReturnCode ret2 = m_AxisIF2.EnableDrive(true);
                txtReturn2.Text = ret2.ToString();
                EAxisReturnCode ret3 = m_AxisIF3.EnableDrive(true);
                txtReturn3.Text = ret3.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void cmdDisable_Click(object sender, EventArgs e)
        {
            try
            {
                EAxisReturnCode ret1 = m_AxisIF1.EnableDrive(false);
                txtReturn1.Text = ret1.ToString();
                EAxisReturnCode ret2 = m_AxisIF2.EnableDrive(false);
                txtReturn2.Text = ret2.ToString();
                EAxisReturnCode ret3 = m_AxisIF3.EnableDrive(false);
                txtReturn3.Text = ret3.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void radPrimary_CheckedChanged(object sender, EventArgs e)
        {
            m_AxisIF1.SelectMode(E_AXIS_MODE.PRIMARY_MODE);
            m_AxisIF2.SelectMode(E_AXIS_MODE.PRIMARY_MODE);
            m_AxisIF3.SelectMode(E_AXIS_MODE.PRIMARY_MODE);
        }

        private void radSec1_CheckedChanged(object sender, EventArgs e)
        {
            m_AxisIF1.SelectMode(E_AXIS_MODE.SECONDARY_MODE_1);
            m_AxisIF2.SelectMode(E_AXIS_MODE.SECONDARY_MODE_1);
            m_AxisIF2.SelectMode(E_AXIS_MODE.SECONDARY_MODE_1);
        }

        private void radSec2_CheckedChanged(object sender, EventArgs e)
        {
            m_AxisIF1.SelectMode(E_AXIS_MODE.SECONDARY_MODE_2);
            m_AxisIF2.SelectMode(E_AXIS_MODE.SECONDARY_MODE_2);
            m_AxisIF2.SelectMode(E_AXIS_MODE.SECONDARY_MODE_2);
        }

        private void radSec3_CheckedChanged(object sender, EventArgs e)
        {
            m_AxisIF1.SelectMode(E_AXIS_MODE.SECONDARY_MODE_3);
            m_AxisIF2.SelectMode(E_AXIS_MODE.SECONDARY_MODE_3);
            m_AxisIF2.SelectMode(E_AXIS_MODE.SECONDARY_MODE_3);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectMode.Checked == true)
            {
                grpSelectMode.Enabled = true;
            }
            else 
            {
                grpSelectMode.Enabled = false;
            }
        }

        private void cmdDock_Click(object sender, EventArgs e)
        {
            try
            {
                EAxisReturnCode ExecuteReturn1 = m_AxisIF1.ExecuteProcedureCommand(E_SERCOS_ID.DOCK_SYSTEM, E_PROCEDURE_CMD.CMD_ENABLE);
                txtReturn1.Text = ExecuteReturn1.ToString();
                EAxisReturnCode ExecuteReturn2 = m_AxisIF2.ExecuteProcedureCommand(E_SERCOS_ID.DOCK_SYSTEM, E_PROCEDURE_CMD.CMD_ENABLE);
                txtReturn2.Text = ExecuteReturn2.ToString();
                EAxisReturnCode ExecuteReturn3 = m_AxisIF3.ExecuteProcedureCommand(E_SERCOS_ID.DOCK_SYSTEM, E_PROCEDURE_CMD.CMD_ENABLE);
                txtReturn3.Text = ExecuteReturn3.ToString();             
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void txtReturn3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
