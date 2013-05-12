set CURDIR=%~dp0

set SVCUTIL_OPTIONS=/directory:"%CURDIR%\wsdl-gen" /syncOnly

svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/device/wsdl/devicemgmt.wsdl /out:devicemgmt.cs /config:devicemgmt.config
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/event/wsdl/event.wsdl /out:event.cs /config:event.config
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/display.wsdl /out:display.cs /config:display.config
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/deviceio.wsdl /out:deviceio.cs /config:deviceio.config
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver20/imaging/wsdl/imaging.wsdl /out:imaging.cs /config:imaging.config
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/media/wsdl/media.wsdl /out:media.cs /config:media.config
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver20/ptz/wsdl/ptz.wsdl /out:ptz.cs /config:ptz.config
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/receiver.wsdl /out:receiver.cs /config:receiver.config
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/recording.wsdl /out:recording.cs /config:recording.config
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/search.wsdl /out:search.cs /config:search.config
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/network/wsdl/remotediscovery.wsdl /out:remotediscovery.cs /config:remotediscovery.config
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/replay.wsdl /out:replay.cs /config:replay.config
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver20/analytics/wsdl/analytics.wsdl /out:analytics.cs /config:analytics.config
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/analyticsdevice.wsdl /out:analyticsdevice.cs /config:analyticsdevice.config
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/ver10/actionengine.wsdl /out:actionengine.cs /config:actionengine.config
