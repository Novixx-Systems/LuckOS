
MICROSOFT Terminal Server Client for the Handheld PC

(c) 1999 Microsoft Corporation. All rights reserved.

This document provides late-breaking or other information supplementing the
documentation for the Microsoft(R) Terminal Server Client for the Handheld PC.

INSTALLATION NOTE: Before installing the Terminal Server Client for the Handheld PC, you
must have Windows CE Services installed on your desktop machine.

1. Windows CE, Handheld PC Edition Version 3.0.  This client will only work on devices
   running Windows CE, Handheld PC Edition Version 3.0 (which includes core OS version
   2.11).  No other versions of Windows CE are supported.

2. Color Palette. On certain devices, maroon, olive and green colors may display as shades
   of grey. This issue is caused by a backwards-compatability option that is set by default
   on Windows CE devices. If you do not use any applications that were designed for Windows
   CE Version 1.0, you can turn off the compatability option by editing your device's
   system registry and deleting the following key:

	HKEY_LOCAL_MACHINE\SYSTEM\GDI\V1PALETTEINDEX

   IMPORTANT: Deleting this key will cause applications written for Windows CE Version 1.0
   to display incorrectly on your device. DO NOT delete this registry key if you run
   any applications that were written for Windows CE Version 1.0.

   The registry entry can be deleted using the Pocket Registry Editor, part of the
   Windows CE PowerToys version 3.0 package available at http://www.microsoft.com/windowsce/

3. Fixed Palette Devices. Some devices use a fixed palette for displaying colors, but
   do not correctly report this to the Terminal Server Client. In such cases, the
   client will display the session using incorrect colors. To work around this issue,
   go to the "HKEY_LOCAL_MACHINE\Software\Microsoft\Terminal Server Client" key in the
   device's registry, and create an entry named "paletteIsFixed" with a DWORD value of 1.

   The registry entry can be created using the Pocket Registry Editor, part of the
   Windows CE PowerToys version 3.0 package available at http://www.microsoft.com/windowsce/

4. Alt key. Certain Alt-key combinations, such as PgDown (Alt+Down Arrow) may not work
   correctly. If this occurs with your device, contact your device's manufacturer about
   obtaining updated keyboard drivers.

   This problem does not affect the Alt-key when it is used to acecss menus and keyboard
   shortcuts.
 
5. Num Lock key. The num lock key is not supported.

6. Graphics-Intensive Applications. Running graphics intensive applications, such as
   screen savers, in the Terminal Server session is not recommended. Doing so can cause
   the client to disconnect from the server.

7. Double Tap on a Touch Screen Device. You may experience difficulty double
   tapping on touch device. This can be remedied by changing default double
   click area in the NT session to be larger to handle the greater variation in
   double taps (taps) vs. double clicks (mouse). These changes must be made in
   the following registry keys on the NT Server:

	HKCU\Control Panel\Mouse\DoubleClickHeight
	HKCU\Control Panel\Mouse\DoubleClickWidth

   Both are set to 4 by default. Changing the value of each to 20 alleviates the problem.

8. Keyboard Shortcuts. Many shortcuts that are available on the Windows 9x and
   Windows NT Terminal Server Clients are not supported in this version. The
   following shortcuts are not supported:

      CTRL+ALT+END 	starts the Windows NT Security dialog box.
 
      ALT+PAGE UP 	switches between programs from left to right.
 
      ALT+PAGE DOWN 	switches between programs from right to left.
 
      ALT+INSERT 	cycles through the programs in launched order.
  
      ALT+HOME 		displays the Start menu.
 
      CTRL+ALT+BREAK    switches the Client between a window and a full screen.

9. Support for Handwriting Recognition Software. This version of the Terminal Server Client
   has been tested with the Calligrapher handwriting recognition software. Entering English
   text to a server that is configured with the standard U.S. keyboard layout
   works correctly. Entering English text when the server is set to an alternative keyboard
   layout (such as Dvorak) is not supported. The spell check feature of Calligrapher is
   not supported.

10. Support for International Devices. The Terminal Server Client may not function correctly
    on international devices that use non-US keyboard layouts. If this occurs with
    your device, contact your device's manufacturer about obtaining updated keyboard
    drivers.