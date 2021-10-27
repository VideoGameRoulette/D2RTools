# D2RTools
![Release](https://img.shields.io/github/v/release/VideoGameRoulette/D2RTools?label=current%20release&style=for-the-badge)
![Date](https://img.shields.io/github/release-date/VideoGameRoulette/D2RTools?style=for-the-badge)
![Downloads](https://img.shields.io/github/downloads/VideoGameRoulette/D2RTools/total?color=%23007EC6&style=for-the-badge)

TCP Server IP Fetcher Tool for D2R

Created By: VideoGameRoulette

Credits: Squirrelies (PInvoke and DEVMODE), michel-pi (GameOverlay.net), and SharpDX Team

## How to Install
- [TCPView Download Link](https://download.sysinternals.com/files/TCPView.zip)
- [Latest Release D2RTools](https://github.com/VideoGameRoulette/D2RTools/releases/latest)
- Download and Extract files from TCPView.zip to any desired folder. example "Desktop/TCPView"

![TCPView Install Example](https://cdn.discordapp.com/attachments/551840398016774193/900437181947084830/unknown.png)
- Download and Extract files from latest release of D2RTools to you TCPView folder.

![D2RTools Install Example](https://cdn.discordapp.com/attachments/551840398016774193/900437658453557248/unknown.png)
## How to Use
- Open D2RTools.exe.
- If you have been given an IP address for DClone hunt simply fill in the IP address into the text box and click "Fetch IP" or check the Enable Auto Fetch.
- If the IP address font color is green like shown below you have matched the IP address you are searching for.

![inappgoodip](https://cdn.discordapp.com/attachments/551840398016774193/900439470967509002/unknown.png)
![ingamegoodip](https://cdn.discordapp.com/attachments/551840398016774193/900439819489009744/unknown.png)
- If the IP address font color is red like below the IP address did not match the search params, or it is possibly a previously checked IP in the list.

![inappbadip](https://cdn.discordapp.com/attachments/551840398016774193/900439413362933801/unknown.png)
![ingamebadip](https://cdn.discordapp.com/attachments/551840398016774193/900439911478485032/unknown.png)
- If you have not given it an IP address to search for if the text returns white (gold ingame) then you haven't checked that server to see if sojs have sold once confirmed no sojs are sold click "Checked IP" button to send current server IP to checked IP list.

![inappunknownip](https://cdn.discordapp.com/attachments/551840398016774193/900440023856451584/unknown.png)
![ingameunknownip](https://cdn.discordapp.com/attachments/551840398016774193/900440238617419816/unknown.png)
- If you find a server where soj's are walking and want to take note of IP for secondary accounts click the Copy IP button to copy the IP to clipboard then paste in the textbox to help search for IP on other accounts.

- To enable fetching ip's automatically, simply check the Enable Auto Fetch checkbox to refresh ip once every second.

![inappoptionsfetch](https://cdn.discordapp.com/attachments/551840398016774193/900440614519316551/unknown.png)
- To enable in-game overlay UI, simply check the Enable DX Overlay checkbox to have both IP and Timer shown above game window.

![inappoptionsui](https://cdn.discordapp.com/attachments/551840398016774193/900440574333681664/unknown.png)
- To customize the UI use the settings tab on the left while DirectXOverlay is disabled to make edits to your UI.

![customsettings](https://cdn.discordapp.com/attachments/551840398016774193/900441478537560185/unknown.png)
## Frequesntly Asked Questions

### Q: IP seems to be flickering outside of a game what should I do?
- If this is happening this means there are other servers I have yet to filter within the 3 different realms (America, Europe, Asia) if this happens click Copy IP to send me a report with the IP in question to add to our list.

### Q: Can the DirectX Overlay be edited in real time?
- Yes it can but the FontFamily field may error if you try to change that while its running, I would always suggest disabling the overlay before any Font style changes.

### Q: I accidently added an IP before an SOJ was sold how do I remove it?
- Click on the IP in the list, then click the "Remove Seleceted IP" button, followed by a prompt to make sure you want to delete it from list, click "Ok" and it should remove it from the list of checked IP addresses.

### Q: How do I reset my list for new DClone hunt?
- Click the "Clear All" button followed by a prompt to make sure you want to clear the entire list, click "Ok" and it should clear all entries from the list.

### Q: Do I need to supply an IP address to use this tool?
- No you can hunt with or without an IP address provided, it just makes things easier to keep track of without an IP supplied so you can keep track of IP's you've checked already.

### Q: Why do I need to download TCPView? Can't you do what it's doing as well.
- Currently researching how to effectively replicate what TCPView is doing to remove the need for it, but for now this is the safest way to obtain the IP address without triggering any anti cheat flags connecting to the games process directly to fetch info.

### Q: Can I get banned using this tool?
- Like any third party tools, Blizzard / Battle.net holds the right to ban anyone using third party tools to gain any sort of advantage in the game.

### Blizzard TOS
![BlizzTOS](https://cdn.discordapp.com/attachments/551840398016774193/900443637563920425/Group_1.png)
