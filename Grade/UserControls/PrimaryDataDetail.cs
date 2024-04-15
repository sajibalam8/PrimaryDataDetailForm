using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Grade
{
    public partial class PrimaryDataDetail : UserControl
    {
        string sqlServerConnectionString = "Server=Sai-sql08-dev;Database=HSBCKDB;Integrated Security = true;TrustServerCertificate=true;";
        public string schedCons = string.Empty;
        public PrimaryDataDetail()
        {
            InitializeComponent();
        }

        private void backgroundWorkerPrimaryDataDetail_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlServerConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand($"Select * from V_F_PDI WHERE SCHED_CONS LIKE '%{schedCons}'", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            if (dt.Rows.Count > 0)
                            {
                                //Schedule Info
                                textBoxSchedDate.Text = Convert.ToDateTime(dt.Rows[0]["SCHEDULE_DATE"]).ToString("dd-MMM-yy");
                                checkBoxTestSched.Checked = !(bool)dt.Rows[0]["TEST_SCHEDULE_YN"]?.ToString().Equals("N");
                                checkBoxDiffCharge.Checked = !(bool)dt.Rows[0]["DIFF_CHARGE_YN"]?.ToString().Equals("N");
                                checkBoxHotCharge.Checked = !(bool)dt.Rows[0]["HOT_CHARGE_YN"]?.ToString().Equals("N");
                                textBoxFmRollTyp.Text = dt.Rows[0]["FM_ROLL_TYPES"]?.ToString();
                                textBoxHeatStrat.Text = dt.Rows[0]["HEAT_STRATEGY"]?.ToString();

                                double.TryParse(dt.Rows[0]["WALKER_FCE_IPH"]?.ToString(), out double wlkFceSpd);
                                textBoxWlkFceSpd.Text = wlkFceSpd.ToString("0.00");

                                double.TryParse(dt.Rows[0]["PUSHER_FCE_IPH"]?.ToString(), out double pshFceSpd);
                                textBoxPshFceSpd.Text = pshFceSpd.ToString("0.00");

                                //Grade/Product
                                textBoxGradeLev3.Text = dt.Rows[0]["GRADE_ID_LEVEL3"]?.ToString();
                                textBoxGradeLev3Actual.Text = dt.Rows[0]["GRADE_ID"]?.ToString();
                                textBoxProdCodeRef.Text = dt.Rows[0]["PRODUCT_CODE_REF"]?.ToString();
                                textBoxProdCodeActual.Text = dt.Rows[0]["PRODUCT_CODE"]?.ToString();

                                //General
                                double.TryParse(dt.Rows[0]["SCHED_NUM"]?.ToString(), out double schedNumber);
                                textBoxSchedNo.Text = schedNumber.ToString("0");

                                double.TryParse(dt.Rows[0]["CONS_NUM"]?.ToString(), out double consNumber);
                                textBoxConsNo.Text = consNumber.ToString("0");

                                textBoxStatus.Text = GetStatusBySchedCons(dt.Rows[0]["SCHED_CONS"]?.ToString());

                                double.TryParse(dt.Rows[0]["STRIP_PICKLE_WIDTH"]?.ToString(), out double pickleWidth);
                                textBoxPickleWidth.Text = Math.Round(pickleWidth, 2).ToString("0.00");

                                textBoxLocationArea.Text = dt.Rows[0]["LOCATION_AREA"]?.ToString();
                                textBoxRollWeek.Text = Convert.ToDateTime(dt.Rows[0]["ROLL_WEEK"]).ToString("dd-MMM-yy");
                                textBoxAltGauage.Text = dt.Rows[0]["STRIP_GAGE_ALTERNATE"]?.ToString();
                                textBox4Weld.Text = dt.Rows[0]["WELD_TYPE_CODE"]?.ToString();

                                double.TryParse(dt.Rows[0]["CROWN_SCHEDULED"]?.ToString(), out double schedCrown);
                                textBoxSchedCrown.Text = schedCrown.ToString("0.00");

                                textBoxGranCtrlCode.Text = dt.Rows[0]["GRAIN_CONTROL_CODE"]?.ToString();
                                textBoxInspCode.Text = dt.Rows[0]["INSPECTION_CODE"]?.ToString();
                                textBoxIntCode01.Text = dt.Rows[0]["HSM_INTERNAL_CODE1"]?.ToString();
                                textBoxIntCode02.Text = dt.Rows[0]["HSM_INTERNAL_CODE2"]?.ToString();
                                textBoxIntCode03.Text = dt.Rows[0]["HSM_INTERNAL_CODE3"]?.ToString();
                                textBoxQualityProse.Text = dt.Rows[0]["QUALITY_PROSE"]?.ToString();
                                textBoxQualityGauge.Text = dt.Rows[0]["GAUGE_QUALITY_SEV"]?.ToString();

                                double.TryParse(dt.Rows[0]["SURFACE_QUALITY_SEV"]?.ToString(), out double surface);
                                textBoxSurface.Text = surface.ToString("0");

                                double.TryParse(dt.Rows[0]["FLATNESS_QUALITY_SEV"]?.ToString(), out double flat);
                                textBoxFlat.Text = flat.ToString("0");

                                double.TryParse(dt.Rows[0]["CROWN_QUALITY_SEV"]?.ToString(), out double crown);
                                textBoxCrown.Text = crown.ToString("0");

                                checkBoxMilEdge.Checked = !(bool)dt.Rows[0]["MILL_EDGE_YN"]?.ToString().Equals("N");
                                checkBoxQRollChange.Checked = !(bool)dt.Rows[0]["Q_ROLL_CHANGE_YN"]?.ToString().Equals("N");

                                //Temperature
                                double.TryParse(dt.Rows[0]["F7_TEMP_MIN_REF"]?.ToString(), out double f7MinRef);
                                textBoxF7MinRef.Text = f7MinRef.ToString("0");

                                double.TryParse(dt.Rows[0]["F7_TEMP_MIN"]?.ToString(), out double f7MinAct);
                                textBoxF7MinAct.Text = f7MinAct.ToString("0");

                                double.TryParse(dt.Rows[0]["F7_TEMP_MAX"]?.ToString(), out double f7Max);
                                textBoxF7Max.Text = f7Max.ToString("0");

                                double.TryParse(dt.Rows[0]["COIL_TEMP_AIM_REF"]?.ToString(), out double coilAimRef);
                                textBoxCoilAimRef.Text = coilAimRef.ToString("0");

                                double.TryParse(dt.Rows[0]["COIL_TEMP_AIM"]?.ToString(), out double coilAimAct);
                                textBoxCoilAimAct.Text = coilAimAct.ToString("0");

                                double.TryParse(dt.Rows[0]["COIL_TEMP_MIN"]?.ToString(), out double coilMin);
                                textBoxCoilMin.Text = coilMin.ToString("0");

                                double.TryParse(dt.Rows[0]["COIL_TEMP_MAX"]?.ToString(), out double coilMax);
                                textBoxCoilMax.Text = coilMax.ToString("0");

                                //Slab Information
                                double.TryParse(dt.Rows[0]["SLAB_NAR_WIDTH"]?.ToString(), out double slabInformationWidthNarrow);
                                textBoxSlabInformationWidthNarrow.Text = slabInformationWidthNarrow.ToString("0.00");

                                double.TryParse(dt.Rows[0]["SLAB_WIDE_WIDTH"]?.ToString(), out double slabInformationWidthWide);
                                textBoxSlabInformationWidthWide.Text = slabInformationWidthWide.ToString("0.00");

                                textBoxSlabInformationGaugeRef.Text = dt.Rows[0]["SLAB_THICKNESS_REF"]?.ToString();
                                textBoxSlabInformationGaugeActual.Text = dt.Rows[0]["SLAB_THICKNESS"]?.ToString();

                                double.TryParse(dt.Rows[0]["SLAB_LENGTH_REF"]?.ToString(), out double slabInformationLengthRef);
                                textBoxSlabInformationLengthRef.Text = slabInformationLengthRef.ToString("0.0");

                                double.TryParse(dt.Rows[0]["SLAB_LENGTH"]?.ToString(), out double slabInformationLengthActual);
                                textBoxSlabInformationLengthActual.Text = slabInformationLengthActual.ToString("0.0");

                                double.TryParse(dt.Rows[0]["SLAB_WEIGHT_REF"]?.ToString(), out double slabInformationWeightRef);
                                textBoxSlabInformationWeightRef.Text = slabInformationWeightRef.ToString("0");

                                double.TryParse(dt.Rows[0]["SLAB_WEIGHT"]?.ToString(), out double slabInformationWeightActual);
                                textBoxSlabInformationWeightActual.Text = slabInformationWeightActual.ToString("0");

                                textBoxSlabInformationCastTime.Text = Convert.ToDateTime(dt.Rows[0]["CAST_TIME"]).ToString("dd-MMM-yy HH:mm");
                                textBoxSlabInformationHeatNo.Text = dt.Rows[0]["HEAT_NUM"]?.ToString();
                                textBoxSlabInformationHeatSeq.Text = dt.Rows[0]["HEAT_SEQ"]?.ToString();

                                //Bar Information
                                double.TryParse(dt.Rows[0]["BAR_WIDTH_AIM_REF"]?.ToString(), out double barInformationAimWidthRef);
                                textBoxBarInformationAimWidthRef.Text = barInformationAimWidthRef.ToString("0.00");

                                double.TryParse(dt.Rows[0]["BAR_WIDTH_AIM"]?.ToString(), out double barInformationAimWidthActual);
                                textBoxBarInformationAimWidthActual.Text = barInformationAimWidthActual.ToString("0.00");

                                double.TryParse(dt.Rows[0]["BAR_WIDTH_ADD_ON"]?.ToString(), out double barInformationWidthAddOnActual);
                                textBoxBarInformationWidthAddOnActual.Text = barInformationWidthAddOnActual.ToString("0.00");

                                textBoxBarInformationAimGaugeRef.Text = dt.Rows[0]["BAR_GAGE_AIM_REF"]?.ToString();
                                textBoxBarInformationAimGaugeActual.Text = dt.Rows[0]["BAR_GAGE_AIM"]?.ToString();

                                //Strip Information
                                double.TryParse(dt.Rows[0]["STRIP_WIDTH_AIM_REF"]?.ToString(), out double aimWidthRef);
                                textBoxAimWidthRef.Text = aimWidthRef.ToString("0.00");

                                double.TryParse(dt.Rows[0]["STRIP_WIDTH_AIM"]?.ToString(), out double aimWidthActual);
                                textBoxAimWidthActual.Text = aimWidthActual.ToString("0.00");

                                double.TryParse(dt.Rows[0]["STRIP_GAGE_AIM_REF"]?.ToString(), out double aimGaugeRef);
                                textBoxAimGaugeRef.Text = aimGaugeRef.ToString("0.0000");

                                double.TryParse(dt.Rows[0]["STRIP_GAGE_AIM"]?.ToString(), out double aimGaugeActual);
                                textBoxAimGaugeActual.Text = aimGaugeActual.ToString("0.0000");

                                double.TryParse(dt.Rows[0]["STRIP_GAGE_TAPER_REF"]?.ToString(), out double gaugeTaperRef);
                                textBoxGaugeTaperRef.Text = gaugeTaperRef.ToString("0.00");

                                double.TryParse(dt.Rows[0]["STRIP_GAGE_TAPER"]?.ToString(), out double gaugeTaperActual);
                                textBoxGaugeTaperActual.Text = gaugeTaperActual.ToString("0.00");

                                double.TryParse(dt.Rows[0]["STRIP_WIDTH_MIN"]?.ToString(), out double widthMin);
                                textBoxWidthMin.Text = widthMin.ToString("0.00");

                                double.TryParse(dt.Rows[0]["STRIP_WIDTH_MAX"]?.ToString(), out double widthMax);
                                textBoxWidthMax.Text = widthMax.ToString("0.00");

                                double.TryParse(dt.Rows[0]["STRIP_GAGE_MIN"]?.ToString(), out double gaugeMin);
                                textBoxGaugeMin.Text = gaugeMin.ToString("0.0000");

                                double.TryParse(dt.Rows[0]["STRIP_GAGE_MAX"]?.ToString(), out double gaugeMax);
                                textBoxGaugeMax.Text = gaugeMax.ToString("0.0000");
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

        private string GetStatusBySchedCons(string schedCons)
        {
            string status = "'<ERROR>'";;
            try
            {
                //Check for Status 0
                using (SqlConnection connection = new SqlConnection(sqlServerConnectionString))
                {
                    connection.Open();
                    using (SqlCommand commandForStatus0 = new SqlCommand($"SELECT[CONS_NUM] FROM [HSBCKDB].[dbo].[PDI] WHERE [SCHED_CONS] = '{schedCons}'", connection))
                    {
                        using (SqlDataReader readerForStatus0 = commandForStatus0.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(readerForStatus0);
                            if (dt.Rows.Count > 0)
                            {
                                return "SCHED";
                            }
                            else
                            {
                                //Check for status 1
                                using (SqlCommand commandForStatus1 = new SqlCommand($"SELECT LOC_SEQ FROM [HSBCKDB].[dbo].[TRACKING_PRE_FCE] WHERE[SCHED_CONS] = '{schedCons}'", connection))
                                {
                                    using (SqlDataReader readerForStatus1 = commandForStatus1.ExecuteReader())
                                    {
                                        dt = new DataTable();
                                        dt.Load(readerForStatus1);
                                        if (dt.Rows.Count > 0)
                                        {
                                            return "TRACKING";
                                        }
                                        else
                                        {
                                            //Check for status 2
                                            using (SqlCommand commandForStatus2 = new SqlCommand($"SELECT FCE_INDEX FROM [HSBCKDB].[dbo].[FCE_TRACKING] WHERE[SCHED_CONS] = '{schedCons}'", connection))
                                            {
                                                using (SqlDataReader readerForStatus2 = commandForStatus2.ExecuteReader())
                                                {
                                                    dt = new DataTable();
                                                    dt.Load(readerForStatus2);
                                                    if (dt.Rows.Count > 0)
                                                    {
                                                        return "IN FCE";
                                                    }
                                                    else
                                                    {
                                                        //Check for status 3
                                                        using (SqlCommand commandForStatus3 = new SqlCommand($"SELECT DISTINCT(SCHED_CONS) FROM [HSBCKDB].[dbo].[TRACKING] WHERE[SCHED_CONS] = '{schedCons}' AND PART = '0'", connection))
                                                        {
                                                            using (SqlDataReader readerForStatus3 = commandForStatus3.ExecuteReader())
                                                            {
                                                                dt = new DataTable();
                                                                dt.Load(readerForStatus2);
                                                                if (dt.Rows.Count > 0)
                                                                {
                                                                    return "IN MILL";
                                                                }
                                                                else
                                                                {
                                                                    //Check for status 4
                                                                    using (SqlCommand commandForStatus4 = new SqlCommand($"SELECT SCHED_CONS FROM [HSBCKDB].[dbo].[PDO] WHERE[SCHED_CONS] = '{schedCons}' AND PART = '0'", connection))
                                                                    {
                                                                        using (SqlDataReader readerForStatus4 = commandForStatus4.ExecuteReader())
                                                                        {
                                                                            dt = new DataTable();
                                                                            dt.Load(readerForStatus4);
                                                                            if (dt.Rows.Count > 0)
                                                                            {
                                                                                return "FINISHED";
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }

                                                    }
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }    
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return status;
        }
    }
}
