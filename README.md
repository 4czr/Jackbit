# Jackbit
Jackbit is an extremely easy example of how a Bitcoin address clipboard hijacker can work, with a whopping 14 lines of code from start to finish! The file opens hidden to minimize user visibility and will constantly check for a BTC address entering the clipboard by use of regex and a timer. The fact that I spent more time writing this README than the actual program and that a VirusTotal scan came back to 4/66 is quite hilarious to me. No persistence, may add that in a future update.

https://www.virustotal.com/gui/file/f435fb0f789cb6bde6e289984bb2be7d4dba8101c53e829c60fd7fe8476d0710?nocache=1

Yes it's .NET. Sue me. .NET 2.0 or higher required

Twitter @_Ozz
Github 4czr
Email ozz@riseup.net

# Version
Jackbit is currently in version **0.1**

#What's To Come?
- May add persistence
- May try and use something other than REGEX to try and reduce the detection
- May add (very easily) multi-coin support