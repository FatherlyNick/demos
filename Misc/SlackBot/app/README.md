Slack bot made in Glitch using Bolt (Slack's official JS API)


1) Edit the .env file and insert your own keys
2) Host the entire app directory on a live server like http://your.server.com/
3) (Assuming you have Events enabled) In Slack/Event subscriptions, link to this app via a url like: http://your.server.com/slack/events
This should report an OK message or a 500 if address is wrong.
4) If step 3 reported OK status, add your app to your Slack workspace -> Slack / Insall app
5) Add some event listeners to your workspace -> Slack event subscriptions / Subscribe to bot events :: messages.im + app_mention; Save changes
6) Add an interactive command -> Slack / Slash commands / Create new command :: Command =  /helloworld ; Request URL = Same URL as in step 3) ; Save changes
7) Re-install the app if needed.
8) Go into your Slack workspace and add the bot in -> Slack / Apps+; Search for your app and add it.
9) Now try to mention the app in its channel -> Slack / <your_app> / Messages ; Type @<your_app>
10) You should get a message back from the app saying "this is an invalid email address"; If you do - its working!
11) Edit app.js if you want to add new functions