# D2R-IPTool
![Release](https://img.shields.io/github/v/release/VideoGameRoulette/D2R-IPTool?label=current%20release&style=for-the-badge)
![Date](https://img.shields.io/github/release-date/VideoGameRoulette/D2R-IPTool?style=for-the-badge)
![Downloads](https://img.shields.io/github/downloads/VideoGameRoulette/D2R-IPTool/total?color=%23007EC6&style=for-the-badge)

TCP Server IP Fetcher Tool for D2R

Created By: VideoGameRoulette

## How to Use
- If you have been given an IP address for DClone hunt simply fill in the IP address into the text box and click "Fetch IP".
- If the IP address font color is green like shown below you have matched the IP address you are searching for.

![screenshot](https://cdn.discordapp.com/attachments/894715703834333225/898430586174181377/unknown.png)
- If the IP address font color is red like below the IP address did not match the search params, or it is possibly a previously checked IP in the list.

![screenshot](https://cdn.discordapp.com/attachments/894715703834333225/898430417634463744/unknown.png)
- If you have not given it an IP address to search for if the text returns white then you haven't checked that server to see if sojs have sold once confirmed no sojs are sold click "Checked IP" button to send current server IP to checked IP list.
- If you find a server where soj's are walking and want to take note of IP for secondary accounts click the Copy IP button to copy the IP to clipboard then paste in the textbox to help search for IP on other accounts.

## Frequesntly Asked Questions

### I accidently added an IP before an SOJ was sold how do I remove it?
- Click on the IP in the list, then click the "Remove Seleceted IP" button, followed by a prompt to make sure you want to delete it from list, click "Ok" and it should remove it from the list of checked IP addresses.

### How do I reset my list for new DClone hunt?
- Click the "Clear All" button followed by a prompt to make sure you want to clear the entire list, click "Ok" and it should clear all entries from the list.

### Do I need to supply an IP address to use this tool?
- No you can hunt with or without an IP address provided, it just makes things easier to keep track of without an IP supplied so you can keep track of IP's you've checked already.

### Why do I need to download TCPView? Can't you do what it's doing as well.
- Currently researching how to effectively replicate what TCPView is doing to remove the need for it, but for now this is the safest way to obtain the IP address without triggering any anti cheat flags connecting to the games process directly to fetch info.

### Can I get banned using this tool?
- Like any third party tools, Blizzard / Battle.net holds the right to ban anyone using third party tools to gain any sort of advantage in the game with that said, if they won't ban users that use TCPView to track down DClone servers this shouldn't be any less safer then just using that since it uses TCPView to get the IP it just makes the data given back from TCPView easier to read since we only care about the specific IP we joined we just have it relay that info from TCPView to the app so no connection is being made to the game directly at all. If you are getting banned its for using TCPView not my software.
