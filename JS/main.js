const chalk = require("chalk"),
{getHWID} = require("hwid"),
express = require("express"),
app = express();

var port = "3000"

app.get('/', function (req, res) {
    getHWID().then(id => res.send(id))
})
  
app.listen(port, function () {
  console.log(`Listening port: ${port}\nYou can also view your HWID here:\nlocalhost:${port}`)
})

getHWID().then(id => console.log(chalk.bgRed.blue("HWID: "+id)));
