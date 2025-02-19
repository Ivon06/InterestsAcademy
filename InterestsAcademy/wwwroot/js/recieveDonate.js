

"use strict"

var connection = new signalR.HubConnectionBuilder()
    .withUrl("/donationHub")
    .build();


start()

async function start() {
    try {
        await connection.start();
        console.log("SignalR Connected.");
    }
    catch (err) {
        console.log(err);
        setTimeout(start, 5000);
    }
};

connection.onclose(async () => {
    await start();
});



connection.on("NewQuantity", function (id, amount) {
    let item = document.getElementById(id);

    item.innerHTML = `Нужно количество: ${amount}`;

});