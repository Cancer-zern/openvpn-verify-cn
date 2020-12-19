# Functionality
verify-cn is checking CN into the file CN_list.txt and if the CN is there it will accept to connect, else deny.

# Requrements
OpenVPN verify CN is working on Windows 7/8/10, Windows Server 2012/2016/2019
Need to install .net Framework 4.6.1 or newer

# OpenVPN server params

 ```
 # Whitelist
script-security 2
tls-verify "verify-cn.exe CN_list.txt"
```

# CN_list.txt example

```
server1
ntserver2
TMP: 00000000
TMP: 12345678
```
