# D2R-IPTool
![Release](https://img.shields.io/github/v/release/VideoGameRoulette/D2R-IPTool?label=current%20release&style=for-the-badge)
![Date](https://img.shields.io/github/release-date/VideoGameRoulette/D2R-IPTool?style=for-the-badge)
![Downloads](https://img.shields.io/github/downloads/VideoGameRoulette/D2R-IPTool/total?color=%23007EC6&style=for-the-badge)

TCP Server IP Fetcher Tool for D2R

Created By: VideoGameRoulette

Credits: Squirrelies (PInvoke and DEVMODE), michel-pi (GameOverlay.net), and SharpDX Team

## How to Use
- Extract all contents of zip file to any folder like shown below.

![installfolder](https://cdn.discordapp.com/attachments/551840398016774193/899313251689586698/unknown.png)

- Open D2R-IPTool.exe.
- If you have been given an IP address for DClone hunt simply fill in the IP address into the text box and click "Fetch IP" or check the Enable Auto Fetch.
- If the IP address font color is green like shown below you have matched the IP address you are searching for.

![inappgoodip](https://cdn.discordapp.com/attachments/551840398016774193/899318973663961158/unknown.png)
![ingamegoodip](https://cdn.discordapp.com/attachments/896955170062209084/899286282457481256/unknown.png)
- If the IP address font color is red like below the IP address did not match the search params, or it is possibly a previously checked IP in the list.

![inappbadip](https://cdn.discordapp.com/attachments/551840398016774193/899318884786659398/unknown.png)
![ingamebadip](https://cdn.discordapp.com/attachments/551840398016774193/899319136000282645/unknown.png)
- If you have not given it an IP address to search for if the text returns white (gold ingame) then you haven't checked that server to see if sojs have sold once confirmed no sojs are sold click "Checked IP" button to send current server IP to checked IP list.

![inappunknownip](https://cdn.discordapp.com/attachments/551840398016774193/899319631767027733/unknown.png)
![ingameunknownip](https://cdn.discordapp.com/attachments/551840398016774193/899319742295322634/unknown.png)
- If you find a server where soj's are walking and want to take note of IP for secondary accounts click the Copy IP button to copy the IP to clipboard then paste in the textbox to help search for IP on other accounts.
- To enable in-game overlay UI, simply check the Enable DX Overlay checkbox to have both IP and Timer shown above game window.

![inappoptions](https://cdn.discordapp.com/attachments/551840398016774193/899320100841213962/unknown.png)

## Frequesntly Asked Questions

### Q: I accidently added an IP before an SOJ was sold how do I remove it?
- Click on the IP in the list, then click the "Remove Seleceted IP" button, followed by a prompt to make sure you want to delete it from list, click "Ok" and it should remove it from the list of checked IP addresses.

### Q: How do I reset my list for new DClone hunt?
- Click the "Clear All" button followed by a prompt to make sure you want to clear the entire list, click "Ok" and it should clear all entries from the list.

### Q: Do I need to supply an IP address to use this tool?
- No you can hunt with or without an IP address provided, it just makes things easier to keep track of without an IP supplied so you can keep track of IP's you've checked already.

### Q: Why do I need to download TCPView? Can't you do what it's doing as well.
- Currently researching how to effectively replicate what TCPView is doing to remove the need for it, but for now this is the safest way to obtain the IP address without triggering any anti cheat flags connecting to the games process directly to fetch info.

### Q: Can I get banned using this tool?
- Like any third party tools, Blizzard / Battle.net holds the right to ban anyone using third party tools to gain any sort of advantage in the game with that said, if they won't ban users that use TCPView to track down DClone servers this shouldn't be any less safer then just using that since it uses TCPView to get the IP it just makes the data given back from TCPView easier to read since we only care about the specific IP we joined we just have it relay that info from TCPView to the app so no connection is being made to the game directly at all. If you are getting banned its for using TCPView not my software.

### Q: Where do I download TCPView?
- [TCPView Download Link](https://download.sysinternals.com/files/TCPView.zip)
