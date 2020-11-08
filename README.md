# verify-cn
Check CN of certificate. (whitelist)


#OpenVPN server params
# Whitelist 
script-security 2 
tls-verify "verify-cn.exe CN_list.txt"

#CN_list.txt example
server1
ntserver2
TMP: 00000000
TMP: 12345678
