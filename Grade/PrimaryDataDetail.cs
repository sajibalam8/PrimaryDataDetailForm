using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade
{
    public partial class PrimaryDataDetail : Form
    {
        string sqlServerConnectionString = "Server=Sai-sql08-dev;Database=HSBCKDB;Integrated Security = true;TrustServerCertificate=true;";
        public PrimaryDataDetail()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void backgroundWorkerPrimaryDataDetail_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlServerConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand($"Select * from V_F_PDI", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            if (dt.Rows.Count > 0)
                            {
                                //Schedule Info
                                textBoxSchedDate.Text = Convert.ToDateTime(dt.Rows[0]["SCHEDULE_DATE"]).ToString("dd-MMM-yyyy");
                                checkBoxTestSched.Checked = !(bool)dt.Rows[0]["TEST_SCHEDULE_YN"]?.ToString().Equals("N");
                                checkBoxDiffCharge.Checked = !(bool)dt.Rows[0]["DIFF_CHARGE_YN"]?.ToString().Equals("N");
                                checkBoxHotCharge.Checked = !(bool)dt.Rows[0]["HOT_CHARGE_YN"]?.ToString().Equals("N");
                                textBoxFmRollTyp.Text = dt.Rows[0]["FM_ROLL_TYPES"]?.ToString();
                                textBoxHeatStrat.Text = dt.Rows[0]["HEAT_STRATEGY"]?.ToString();
                                textBoxWlkFceSpd.Text = dt.Rows[0]["WALKER_FCE_IPH"]?.ToString();
                                 textBoxPshFceSpd.Text = dt.Rows[0]["PUSHER_FCE_IPH"]?.ToString();

                                //Grade/Product
                                textBoxGradeLev3.Text = dt.Rows[0]["GRADE_ID_LEVEL3"]?.ToString();
                                textBoxGradeLev3Actual.Text = dt.Rows[0]["GRADE_ID"]?.ToString();
                                textBoxProdCodeRef.Text = dt.Rows[0]["PRODUCT_CODE_REF"]?.ToString();
                                textBoxProdCodeActual.Text = dt.Rows[0]["PRODUCT_CODE"]?.ToString();

                                //General
                                textBoxSchedNo.Text = dt.Rows[0]["SCHED_NUM"]?.ToString();
                                textBoxConsNo.Text = dt.Rows[0]["CONS_NUM"]?.ToString();
                                textBoxStatus.Text = dt.Rows[0]["PRODUCT_CODE_REF"]?.ToString();
                                textBoxPickleWidth.Text = dt.Rows[0]["STRIP_PICKLE_WIDTH"]?.ToString();
                                textBoxLocationArea.Text = dt.Rows[0]["LOCATION_AREA"]?.ToString();
                                textBoxRollWeek.Text = dt.Rows[0]["ROLL_WEEK"]?.ToString();
                                textBoxAltGauage.Text = dt.Rows[0]["STRIP_GAGE_ALTERNATE"]?.ToString();
                                textBox4Weld.Text = dt.Rows[0]["WELD_TYPE_CODE"]?.ToString();
                                textBoxSchedCrown.Text = dt.Rows[0]["CROWN_SCHEDULED"]?.ToString();
                                textBoxGranCtrlCode.Text = dt.Rows[0]["GRAIN_CONTROL_CODE"]?.ToString();
                                textBoxInspCode.Text = dt.Rows[0]["INSPECTION_CODE"]?.ToString();
                                textBoxIntCode01.Text = dt.Rows[0]["HSM_INTERNAL_CODE1"]?.ToString();
                                textBoxIntCode02.Text = dt.Rows[0]["HSM_INTERNAL_CODE2"]?.ToString();
                                textBoxIntCode03.Text = dt.Rows[0]["HSM_INTERNAL_CODE3"]?.ToString();
                                textBoxQualityProse.Text = dt.Rows[0]["QUALITY_PROSE"]?.ToString();
                                textBoxQualityGauge.Text = dt.Rows[0]["GAUGE_QUALITY_SEV"]?.ToString();
                                textBoxSurface.Text = dt.Rows[0]["SURFACE_QUALITY_SEV"]?.ToString();
                                textBoxFlat.Text = dt.Rows[0]["FLATNESS_QUALITY_SEV"]?.ToString();
                                textBoxCrown.Text = dt.Rows[0]["CROWN_QUALITY_SEV"]?.ToString();
                                checkBoxMilEdge.Checked = !(bool)dt.Rows[0]["MILL_EDGE_YN"]?.ToString().Equals("N");
                                checkBoxQRollChange.Checked = !(bool)dt.Rows[0]["Q_ROLL_CHANGE_YN"]?.ToString().Equals("N");

                                //Temperature
                                textBoxF7MinRef.Text = dt.Rows[0]["F7_TEMP_MIN_REF"]?.ToString();
                                textBoxF7MinAct.Text = dt.Rows[0]["F7_TEMP_MIN"]?.ToString();
                                textBoxF7Max.Text = dt.Rows[0]["F7_TEMP_MAX"]?.ToString();
                                textBoxCoilAimRef.Text = dt.Rows[0]["COIL_TEMP_AIM_REF"]?.ToString();
                                textBoxCoilAimAct.Text = dt.Rows[0]["COIL_TEMP_AIM"]?.ToString();
                                textBoxCoilMin.Text = dt.Rows[0]["COIL_TEMP_MIN"]?.ToString();
                                textBoxCoilMax.Text = dt.Rows[0]["COIL_TEMP_MAX"]?.ToString();

                                //Slab Information
                                textBoxSlabInformationWidthNarrow.Text = dt.Rows[0]["SLAB_NAR_WIDTH"]?.ToString();
                                textBoxSlabInformationWidthWide.Text = dt.Rows[0]["SLAB_WIDE_WIDTH"]?.ToString();
                                textBoxSlabInformationGaugeRef.Text = dt.Rows[0]["SLAB_THICKNESS_REF"]?.ToString();
                                textBoxSlabInformationGaugeActual.Text = dt.Rows[0]["SLAB_THICKNESS"]?.ToString();
                                textBoxSlabInformationLengthRef.Text = dt.Rows[0]["SLAB_LENGTH_REF"]?.ToString();
                                textBoxSlabInformationLengthActual.Text = dt.Rows[0]["SLAB_LENGTH"]?.ToString();
                                textBoxSlabInformationWeightRef.Text = dt.Rows[0]["SLAB_WEIGHT_REF"]?.ToString();
                                textBoxSlabInformationWeightActual.Text = dt.Rows[0]["SLAB_WEIGHT"]?.ToString();
                                textBoxSlabInformationCastTime.Text = Convert.ToDateTime(dt.Rows[0]["CAST_TIME"]).ToString("dd-MMM-yyyy HH:mm");
                                textBoxSlabInformationHeatNo.Text = dt.Rows[0]["HEAT_NUM"]?.ToString();
                                textBoxSlabInformationHeatSeq.Text = dt.Rows[0]["HEAT_SEQ"]?.ToString();

                                //Bar Information
                                textBoxBarInformationAimWidthRef.Text = dt.Rows[0]["BAR_WIDTH_AIM_REF"]?.ToString();
                                textBoxBarInformationAimWidthActual.Text = dt.Rows[0]["BAR_WIDTH_AIM"]?.ToString();
                                textBoxBarInformationWidthAddOnActual.Text = dt.Rows[0]["BAR_WIDTH_ADD_ON"]?.ToString();
                                textBoxBarInformationAimGaugeRef.Text = dt.Rows[0]["BAR_GAGE_AIM_REF"]?.ToString();
                                textBoxBarInformationAimGaugeActual.Text = dt.Rows[0]["BAR_GAGE_AIM"]?.ToString();

                                //Strip Information
                                textBoxAimWidthRef.Text = dt.Rows[0]["STRIP_WIDTH_AIM_REF"]?.ToString();
                                textBoxAimWidthActual.Text = dt.Rows[0]["STRIP_WIDTH_AIM"]?.ToString();
                                textBoxAimGaugeRef.Text = dt.Rows[0]["STRIP_GAGE_AIM_REF"]?.ToString();
                                textBoxAimGaugeActual.Text = dt.Rows[0]["STRIP_GAGE_AIM"]?.ToString();
                                textBoxGaugeTaperRef.Text = dt.Rows[0]["STRIP_GAGE_TAPER_REF"]?.ToString();
                                textBoxGaugeTaperActual.Text = dt.Rows[0]["STRIP_GAGE_TAPER"]?.ToString();
                                textBoxWidthMin.Text = dt.Rows[0]["STRIP_WIDTH_MIN"]?.ToString();
                                textBoxWidthMax.Text = dt.Rows[0]["STRIP_WIDTH_MAX"]?.ToString();
                                textBoxGaugeMin.Text = dt.Rows[0]["STRIP_GAGE_MIN"]?.ToString();
                                textBoxGaugeMax.Text = dt.Rows[0]["STRIP_GAGE_MAX"]?.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }

        private void PrimaryDataDetail_Load(object sender, EventArgs e)
        {
            try
            {
                backgroundWorkerPrimaryDataDetail.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }

        private void textBoxIntCode01_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIntCode02_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIntCode03_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxF7MinAct_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBarInformationAimGaugeActual_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
