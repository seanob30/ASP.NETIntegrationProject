function showEvents(eventType) {
    $('.table').find('tbody').empty();

    var oArgs = {
        app_key: "mbK7CNpm3twn8nJH",
        location: "San Francisco",
        q: eventType,
        date: "This Week",
        page_size: 25
    };
    EVDB.API.call("/events/search", oArgs, function (oData) {
        showResults(oData);
    });
    function showResults(oData) {
        $('.table').find('tbody').empty();
        for (var i = 0; i < oData.events.event.length; i++) {
            if (oData.events.event[i].image === null) {
                i++;
            } else {

                $('.table').append(
                 '<tr><td>'+"<img src=" +oData.events.event[i].image.medium.url+ ">"+'</td>'+
                 '<td>' + oData.events.event[i].title + '</td>' +
                 '<td>' + oData.events.event[i].modified + '</td>' +
                 '<td>' + oData.events.event[i].venue_name + '</td>' +
                 '<td>' + oData.events.event[i].venue_address + '</td></tr>')
            }
        }
    }
}

