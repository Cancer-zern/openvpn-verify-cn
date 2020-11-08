# verify-cn
OpenVPN verify CN (Windows 7/8/10, Windows Server 2012/2016/2019)

Need to install .net Framework 4.6.1 or newer


# OpenVPN server params
# Whitelist
 ```
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
