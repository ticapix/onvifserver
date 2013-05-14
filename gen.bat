set CURDIR=%~dp0

call "C:\Program Files (x86)\Microsoft Visual Studio 11.0\VC\vcvarsall.bat" x86_amd64

set SVCUTIL_OPTIONS=/directory:"%CURDIR%\wsdl-gen" /syncOnly

svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/device/wsdl/devicemgmt.wsdl /out:devicemgmt.cs /config:devicemgmt.config /namespace:*,Onvif.Devicemgmt
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/event/wsdl/event.wsdl /out:event.cs /config:event.config /namespace:*,Onvif.Event
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/display.wsdl /out:display.cs /config:display.config /namespace:*,Onvif.Display
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/deviceio.wsdl /out:deviceio.cs /config:deviceio.config /namespace:*,Onvif.Deviceio
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver20/imaging/wsdl/imaging.wsdl /out:imaging.cs /config:imaging.config /namespace:*,Onvif.Imaging
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/media/wsdl/media.wsdl /out:media.cs /config:media.config /namespace:*,Onvif.Media
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver20/ptz/wsdl/ptz.wsdl /out:ptz.cs /config:ptz.config /namespace:*,Onvif.Ptz
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/receiver.wsdl /out:receiver.cs /config:receiver.config /namespace:*,Onvif.Receiver
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/recording.wsdl /out:recording.cs /config:recording.config /namespace:*,Onvif.Recording
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/search.wsdl /out:search.cs /config:search.config /namespace:*,Onvif.Search
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/network/wsdl/remotediscovery.wsdl /out:remotediscovery.cs /config:remotediscovery.config /namespace:*,Onvif.Remotediscovery
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/replay.wsdl /out:replay.cs /config:replay.config /namespace:*,Onvif.Replay
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver20/analytics/wsdl/analytics.wsdl /out:analytics.cs /config:analytics.config /namespace:*,Onvif.Analytics
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/onvif/ver10/analyticsdevice.wsdl /out:analyticsdevice.cs /config:analyticsdevice.config /namespace:*,Onvif.Analyticsdevice
svcutil %SVCUTIL_OPTIONS% http://www.onvif.org/ver10/actionengine.wsdl /out:actionengine.cs /config:actionengine.config /namespace:*,Onvif.Actionengine
