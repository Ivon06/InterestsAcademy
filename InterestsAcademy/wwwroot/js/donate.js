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



    // Обработва натискането на бутона за дарение
    document.getElementById('donate').addEventListener('click', function(event) {
        /*e.preventDefault();*/

        var formData = new FormData();
        var itemId = document.getElementById('itemId').value; 
        let quantity = document.getElementById('quantity').value;
        let t = $("input[name='__RequestVerificationToken']").val();


        $.ajax({
            url: "/Donation/Donate?id=" + itemId,
            type: "POST",
            data: {
                'id': itemId,
                'quantity': quantity
            },
            dataType: "json",
            headers: {
                "RequestVerificationToken": t
            },
            success: async function (data) {
                if (data) {
                    try {
                        await connection.invoke("UpdateDonations", itemId, data.amount);

                    }
                    catch (err) {
                        console.error(err);
                    }

                    let url = new URL(window.location);
                    let params = url.searchParams;

                    window.location = `${url.origin}/Donation/Categories?category=All`;
                }
            },
            error: function (err) {
                console.error("Грешка при дарение:", err);
            }
        });
    });

    // Обновяване на количеството при промяна

