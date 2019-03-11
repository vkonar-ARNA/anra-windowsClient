using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Services.Interfaces;
using ANRA_WindowsClient.DTO;

namespace ANRA_WindowsClient
{
	public partial class Main : Form
	{
		//private IConnect _connection;
		//private ManualResetEvent SerialThreadrunner = new ManualResetEvent(false);
		//private UDPProcessor udpProcessor;
		//private IAnraSocketClient anraSocketClient;
		private List<DroneLookupItem> drones;
		private DroneLookupItem selectedDrone;
		private List<OperationLookupItem> operations;
		private List<UssInstanceLookupItem> ussInstanceLookupItems;
		private OperationLookupItem selectedOperation;
		private UssInstanceLookupItem selectedUssInstance;
		//private GeneralMqttClient mqttClient;
		//private ICommsSerial portInfo;
		private AuthResult _authResult;
		private Guid Gufi = Guid.Empty;
		private string USS_SERVER;
		private bool _isSimulatingDetects;
		private bool _useUdpSocket;
		private int UssThrottleSetting = 1;
		//private List<SimulationMain> simulators;

		private List<string> messages = new List<string>();

		private bool isConnected;

		public Main()
		{
			;
		}
		public Main(AuthResult authResult)
		{
			_authResult = authResult;
			InitializeComponent();
			Init();
			SetButtonDisplay();
		}
		private async void Init()
		{
			USS_SERVER = System.Configuration.ConfigurationManager.AppSettings["anraussserver"];
			_isSimulatingDetects = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["simulateDetects"]);
			_useUdpSocket = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["useUdpSocket"]);

			//grpboxSimulation.Visible = _isSimulatingDetects;
			//ConfigurePortTypes();
			//ConfigureTabsVisibility();
			await SetupOperationLookup();
			await SetupUssInstanceLookup();
			//configureSimulation();

		}

		//UDP toggle method
		private void UDPToggle_CheckedChanged(object sender, EventArgs e)
		{
			if (UDPToggle.Checked)
			{
				Gufi = selectedOperation.Gufi;
				StartUDPConnection();
			}
			else
			{
				onCloseCleanup();
				SetButtonDisplay();
				//SaveConsoleLog(anraConsole, "telemetry");
			}
		}
		private void StartUDPConnection()
		{
			if (ValidateTelemetryInput(selectedOperation.Gufi.ToString()))
			{
				//UgcsTelemetry ugcs = new UgcsTelemetry() { };
				//Boolean loginSuccess=ugcs.login();
				//Task ConnectUgcs(String login, String password, System.Action onConnect);

				//udpProcessor = new UDPProcessor(txtPort.Text, selectedDrone.Uid, selectedOperation.Gufi.ToString(), selectedOperation.UssInstanceId, _authResult);
				//udpProcessor.PacketReceived += UdpProcessor_PacketReceived;
				//udpProcessor.Start();
				//HandleMqtt(consoleDSRC, selectedOperation.UssInstanceId);
				//isConnected = true;
				//ConsoleLog("UDP Status: Connected", Color.White);
				SetButtonDisplay();
			}
			else
			{
				isConnected = false;
				UDPToggle.Checked = false;
			}
		}
		/*
		 * 
		 */
		private void onCloseCleanup()
		{
			//isConnected = false;

			//if (udpProcessor != null)
			//	udpProcessor.Disconnect();

			//if (anraSocketClient != null)
			//{
			//	anraSocketClient.Disconnect();
			//	anraSocketClient = null;
			//}

			//if (echoClient != null)
			//{
			//	echoClient.Stop();
			//	echoClient = null;
			//}

			//if (dsrcClient != null)
			//{
			//	dsrcClient.Stop();
			//	dsrcClient = null;
			//}

			//if (mqttClient != null)
			//{
			//	mqttClient.Disconnect();
			//}

			//if (simulators != null && simulators.Any())
			//{
			//	foreach (var s in simulators)
			//	{
			//		s.Dispose();
			//	}
			//}
		}
		//private void SaveConsoleLog(ConsoleControl.ConsoleControl ctrl, string fileName)
		//{
		//	var guid = Guid.NewGuid();
		//	//Create Log Directory If Not Exists
		//	var dirPath = Application.StartupPath + "/logs/";
		//	if (!System.IO.Directory.Exists(dirPath))
		//	{
		//		System.IO.Directory.CreateDirectory(dirPath);
		//	}

		//	var filePath = Application.StartupPath + "/logs/" + $"{fileName}_log_{guid.ToString()}.log";
		//	ctrl.InternalRichTextBox.SaveFile(filePath);
		//	ctrl.ClearOutput();
		//}

		//public void ConsoleLog(string msg, Color color)
		//{
		//	if (anraConsole != null)
		//		anraConsole.WriteOutput("\r\n\r\n" + msg, color);
		//}
		private bool ValidateTelemetryInput(string gufi)
		{
			if (gufi.Length <= 0 || !Guid.TryParse(gufi, out Guid result))
			{
				MessageBox.Show("Enter Gufi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			//if (port.Length <= 0)
			//{
			//	MessageBox.Show("Enter Port number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	return false;
			//}

			//if (selectedDrone == null || selectedDrone.Uid == "0")
			//{
			//	MessageBox.Show("Select Drone.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	return false;
			//}

			return true;
		}
		//udp button
		private void button1_Click(object sender, EventArgs e)
		{
			
		}
		
		//operation label
		private void label2_Click(object sender, EventArgs e)
		{

		}
		private void SetButtonDisplay()
		{
			UDPToggle.Checked = isConnected;
			UDPToggle.Enabled = selectedDrone != null && selectedOperation != null;
		}
		private async Task SetupUssInstanceLookup()
		{
			var proxy = new AnraServiceProxy(USS_SERVER);

			try
			{
				Cursor.Current = Cursors.WaitCursor;
				ussInstanceLookupItems = await proxy.GetUssInstances();
				//cmbUssInstance.DataSource = ussInstanceLookupItems;
				//cmbUssInstance.DisplayMember = "Name";
				//cmbUssInstance.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unable to connect to the remote server. Please check config.", "Anra USS Client Proxy", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		private async Task SetupOperationLookup()
		{
			var proxy = new AnraServiceProxy(USS_SERVER);

			try
			{
				Cursor.Current = Cursors.WaitCursor;
				operations = await proxy.GetOperations();
				cmbOperation.DataSource = operations;
				cmbOperation.DisplayMember = "Gufi";
				cmbOperation.SelectedIndex = -1;

				//if (simulators != null && simulators.Any())
				//{
				//	foreach (var item in simulators) item.RefreshOperationLookup(operations);
				//}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unable to connect to the remote server. Please check config.", "Anra USS Client Proxy",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		private void CmbOperation_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cmbOperation.SelectedValue != null)
			{
				selectedOperation = (OperationLookupItem)cmbOperation.SelectedValue;
				SetButtonDisplay();
			}
		}


	}
}
