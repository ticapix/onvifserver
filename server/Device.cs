using System;

namespace server
{
	public class Device : Onvif.Devicemgmt.Device
	{
		public Device ()
		{
		}

		public Onvif.Devicemgmt.GetServicesResponse GetServices (Onvif.Devicemgmt.GetServicesRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.DeviceServiceCapabilities GetServiceCapabilities ()
		{
			throw new NotImplementedException ();
		}

		public string GetDeviceInformation (out string Model, out string FirmwareVersion, out string SerialNumber, out string HardwareId)
		{
			throw new NotImplementedException ();
		}

		public void SetSystemDateAndTime (Onvif.Devicemgmt.SetDateTimeType DateTimeType, bool DaylightSavings, Onvif.Devicemgmt.TimeZone TimeZone, Onvif.Devicemgmt.DateTime UTCDateTime)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.SystemDateTime GetSystemDateAndTime ()
		{
			throw new NotImplementedException ();
		}

		public void SetSystemFactoryDefault (Onvif.Devicemgmt.FactoryDefaultType FactoryDefault)
		{
			throw new NotImplementedException ();
		}

		public string UpgradeSystemFirmware (Onvif.Devicemgmt.AttachmentData Firmware)
		{
			throw new NotImplementedException ();
		}

		public string SystemReboot ()
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.RestoreSystemResponse RestoreSystem (Onvif.Devicemgmt.RestoreSystemRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.GetSystemBackupResponse GetSystemBackup (Onvif.Devicemgmt.GetSystemBackupRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.SystemLog GetSystemLog (Onvif.Devicemgmt.SystemLogType LogType)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.SupportInformation GetSystemSupportInformation ()
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.GetScopesResponse GetScopes (Onvif.Devicemgmt.GetScopesRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.SetScopesResponse SetScopes (Onvif.Devicemgmt.SetScopesRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.AddScopesResponse AddScopes (Onvif.Devicemgmt.AddScopesRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.RemoveScopesResponse RemoveScopes (Onvif.Devicemgmt.RemoveScopesRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.DiscoveryMode GetDiscoveryMode ()
		{
			throw new NotImplementedException ();
		}

		public void SetDiscoveryMode (Onvif.Devicemgmt.DiscoveryMode DiscoveryMode)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.DiscoveryMode GetRemoteDiscoveryMode ()
		{
			throw new NotImplementedException ();
		}

		public void SetRemoteDiscoveryMode (Onvif.Devicemgmt.DiscoveryMode RemoteDiscoveryMode)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.GetDPAddressesResponse GetDPAddresses (Onvif.Devicemgmt.GetDPAddressesRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.SetDPAddressesResponse SetDPAddresses (Onvif.Devicemgmt.SetDPAddressesRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.GetEndpointReferenceResponse GetEndpointReference (Onvif.Devicemgmt.GetEndpointReferenceRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.RemoteUser GetRemoteUser ()
		{
			throw new NotImplementedException ();
		}

		public void SetRemoteUser (Onvif.Devicemgmt.RemoteUser RemoteUser)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.GetUsersResponse GetUsers (Onvif.Devicemgmt.GetUsersRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.CreateUsersResponse CreateUsers (Onvif.Devicemgmt.CreateUsersRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.DeleteUsersResponse DeleteUsers (Onvif.Devicemgmt.DeleteUsersRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.SetUserResponse SetUser (Onvif.Devicemgmt.SetUserRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.GetWsdlUrlResponse GetWsdlUrl (Onvif.Devicemgmt.GetWsdlUrlRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.GetCapabilitiesResponse GetCapabilities (Onvif.Devicemgmt.GetCapabilitiesRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.HostnameInformation GetHostname ()
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.SetHostnameResponse SetHostname (Onvif.Devicemgmt.SetHostnameRequest request)
		{
			throw new NotImplementedException ();
		}

		public bool SetHostnameFromDHCP (bool FromDHCP)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.DNSInformation GetDNS ()
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.SetDNSResponse SetDNS (Onvif.Devicemgmt.SetDNSRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.NTPInformation GetNTP ()
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.SetNTPResponse SetNTP (Onvif.Devicemgmt.SetNTPRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.DynamicDNSInformation GetDynamicDNS ()
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.SetDynamicDNSResponse SetDynamicDNS (Onvif.Devicemgmt.SetDynamicDNSRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.GetNetworkInterfacesResponse GetNetworkInterfaces (Onvif.Devicemgmt.GetNetworkInterfacesRequest request)
		{
			throw new NotImplementedException ();
		}

		public bool SetNetworkInterfaces (string InterfaceToken, Onvif.Devicemgmt.NetworkInterfaceSetConfiguration NetworkInterface)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.GetNetworkProtocolsResponse GetNetworkProtocols (Onvif.Devicemgmt.GetNetworkProtocolsRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.SetNetworkProtocolsResponse SetNetworkProtocols (Onvif.Devicemgmt.SetNetworkProtocolsRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.NetworkGateway GetNetworkDefaultGateway ()
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.SetNetworkDefaultGatewayResponse SetNetworkDefaultGateway (Onvif.Devicemgmt.SetNetworkDefaultGatewayRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.NetworkZeroConfiguration GetZeroConfiguration ()
		{
			throw new NotImplementedException ();
		}

		public void SetZeroConfiguration (string InterfaceToken, bool Enabled)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.IPAddressFilter GetIPAddressFilter ()
		{
			throw new NotImplementedException ();
		}

		public void SetIPAddressFilter (Onvif.Devicemgmt.IPAddressFilter IPAddressFilter)
		{
			throw new NotImplementedException ();
		}

		public void AddIPAddressFilter (Onvif.Devicemgmt.IPAddressFilter IPAddressFilter)
		{
			throw new NotImplementedException ();
		}

		public void RemoveIPAddressFilter (Onvif.Devicemgmt.IPAddressFilter IPAddressFilter)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.BinaryData GetAccessPolicy ()
		{
			throw new NotImplementedException ();
		}

		public void SetAccessPolicy (Onvif.Devicemgmt.BinaryData PolicyFile)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.CreateCertificateResponse CreateCertificate (Onvif.Devicemgmt.CreateCertificateRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.GetCertificatesResponse GetCertificates (Onvif.Devicemgmt.GetCertificatesRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.GetCertificatesStatusResponse GetCertificatesStatus (Onvif.Devicemgmt.GetCertificatesStatusRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.SetCertificatesStatusResponse SetCertificatesStatus (Onvif.Devicemgmt.SetCertificatesStatusRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.DeleteCertificatesResponse DeleteCertificates (Onvif.Devicemgmt.DeleteCertificatesRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.GetPkcs10RequestResponse GetPkcs10Request (Onvif.Devicemgmt.GetPkcs10RequestRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.LoadCertificatesResponse LoadCertificates (Onvif.Devicemgmt.LoadCertificatesRequest request)
		{
			throw new NotImplementedException ();
		}

		public bool GetClientCertificateMode ()
		{
			throw new NotImplementedException ();
		}

		public void SetClientCertificateMode (bool Enabled)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.GetRelayOutputsResponse GetRelayOutputs (Onvif.Devicemgmt.GetRelayOutputsRequest request)
		{
			throw new NotImplementedException ();
		}

		public void SetRelayOutputSettings (string RelayOutputToken, Onvif.Devicemgmt.RelayOutputSettings Properties)
		{
			throw new NotImplementedException ();
		}

		public void SetRelayOutputState (string RelayOutputToken, Onvif.Devicemgmt.RelayLogicalState LogicalState)
		{
			throw new NotImplementedException ();
		}

		public string SendAuxiliaryCommand (string AuxiliaryCommand)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.GetCACertificatesResponse GetCACertificates (Onvif.Devicemgmt.GetCACertificatesRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.LoadCertificateWithPrivateKeyResponse LoadCertificateWithPrivateKey (Onvif.Devicemgmt.LoadCertificateWithPrivateKeyRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.GetCertificateInformationResponse GetCertificateInformation (Onvif.Devicemgmt.GetCertificateInformationRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.LoadCACertificatesResponse LoadCACertificates (Onvif.Devicemgmt.LoadCACertificatesRequest request)
		{
			throw new NotImplementedException ();
		}

		public void CreateDot1XConfiguration (Onvif.Devicemgmt.Dot1XConfiguration Dot1XConfiguration)
		{
			throw new NotImplementedException ();
		}

		public void SetDot1XConfiguration (Onvif.Devicemgmt.Dot1XConfiguration Dot1XConfiguration)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.Dot1XConfiguration GetDot1XConfiguration (string Dot1XConfigurationToken)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.GetDot1XConfigurationsResponse GetDot1XConfigurations (Onvif.Devicemgmt.GetDot1XConfigurationsRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.DeleteDot1XConfigurationResponse DeleteDot1XConfiguration (Onvif.Devicemgmt.DeleteDot1XConfigurationRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.GetDot11CapabilitiesResponse GetDot11Capabilities (Onvif.Devicemgmt.GetDot11CapabilitiesRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.Dot11Status GetDot11Status (string InterfaceToken)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.ScanAvailableDot11NetworksResponse ScanAvailableDot11Networks (Onvif.Devicemgmt.ScanAvailableDot11NetworksRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.GetSystemUrisResponse GetSystemUris (Onvif.Devicemgmt.GetSystemUrisRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.StartFirmwareUpgradeResponse StartFirmwareUpgrade (Onvif.Devicemgmt.StartFirmwareUpgradeRequest request)
		{
			throw new NotImplementedException ();
		}

		public Onvif.Devicemgmt.StartSystemRestoreResponse StartSystemRestore (Onvif.Devicemgmt.StartSystemRestoreRequest request)
		{
			throw new NotImplementedException ();
		}
	}
}

