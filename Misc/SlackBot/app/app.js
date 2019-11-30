// Require the Bolt package (github.com/slackapi/bolt)
const { App } = require("@slack/bolt");

const app = new App({
  token: process.env.SLACK_BOT_TOKEN,
  signingSecret: process.env.SLACK_SIGNING_SECRET
});




// All the room in the world for your code

(async () => {
  // Start your app
  await app.start(process.env.PORT || 3000);

  console.log('Bolt app is running!');
})();

//test event
/*
app.event('message', async ({event, context, message}) => {
  
  try {
    /* view.publish is the method that your app uses to push a view to the Home tab 
   const result = await app.client.chat.postMessage({
      token: context.botToken,
      // Channel to send message to
      channel: message.channel,
      // Include a button in the message (or whatever blocks you want!)
      
      // Text in the notification
      //text: 'Direct Message?'
    });
  }
  catch (error) {
    console.error(error);
  }  
});
*/

app.event('app_home_opened', async ({ event, context, say}) => {
  console.log("Home opened");
 var uid = (`<@${event.user}>`);
  try {
    /* view.publish is the method that your app uses to push a view to the Home tab */
    const result = await app.client.views.publish({

      /* retrieves your xoxb token from context */
      token: context.botToken,

      /* the user ID that opened your app's app home */
      user_id: event.user,
      
      /* the view payload that appears in the app home*/
      view: {
        type: 'home',
        callback_id: 'home_view',

        /* body of the view */
        blocks: [
          {
            "type": "section",
            "text": {
              "type": "mrkdwn",
              "text": "Hi, Welcome to QnA-bot Home page :tada:"+uid
            }
          },
          {
            "type": "divider"
          }
          
        ]
      }
    });
  }
  catch (error) {
    console.error(error);
  }
});

app.command('/helloworld', async ({ ack, payload, context }) => {
  // Acknowledge the command request
  ack();
  console.log("/helloworld command detected");
  //console.log(payload.channel_id);
  //var channel = payload.channel_id;
  try {
    const result = await app.client.chat.postMessage({
      token: context.botToken,
      // Channel to send message to
      channel: payload.channel_id,
      // Include a button in the message (or whatever blocks you want!)
     
      // Text in the notification
      text: 'Hello, world!'
    });
    //console.log(channel);
    console.log(result);
  }
  catch (error) {
    console.error(error);
  }
});

//WAVE

app.message(':wave:', async ({ message, say}) => {
  say(`Hello, <@${message.user}>`);
});


/*

//If the message is help
app.event('message', async ({ message, event, context }) => {
  //var uid = (`<@${event.user}>`);
  //console.log(message.type);
  if(message.text != "help") {
  try {
    const result = await app.client.chat.postMessage({
      token: context.botToken,
      //channel: 'CR6EXP2ET',
      channel: message.channel,
      //text: `I hear you, <@${event.user}>! What do you mean "`+message.text+`"?`
    });
    console.log(result);
  }
  catch (error) {
    //console.log("Channel id is: "+message.channel);
    console.error(error);
  }
  } //end if
  else {
    
    try {
    const result = await app.client.chat.postMessage({
      token: context.botToken,
      //channel: 'CR6EXP2ET',
      channel: message.channel,
      //text: `I hear you, <@${event.user}>! What do you need "`+message.text+`" with?`
    });
    console.log(result);
  }
  catch (error) {
    //console.log("Channel id is: "+message.channel);
    console.error(error);
  }
  }
});
*/

app.event('app_mention', async ({ event, context}) => {
  console.log("App mention detected.");
  //console.log(event.channel); 
  try {
    const result = await app.client.chat.postMessage({
      token: context.botToken,
      //channel: 'CR6EXP2ET',
      channel: event.channel,
      text: `Did someone call my name? Was it you, <@${event.user}> ?`
    });
    console.log(result);
  }
  catch (error) {
    //console.log("Channel id is: "+message.channel);
    console.error(error);
  }
  
});


app.message( async ({ context, say, message }) => {
  // RegExp matches are inside of context.matches
  console.log("Regex working!");
  var isEmail = /[0-9a-zA-Z._%+-]+@.[0-9a-zA-Z._%+-]+/;
  
  if(isEmail.test(message.text)){say(message.text);}else{say("Invalid email address.");}
});