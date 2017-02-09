function showEvents(eventType) {
    $('.table').find('tbody').empty();

    var oArgs = {
        app_key: "mbK7CNpm3twn8nJH",
        location: "San Francisco",
        q: eventType,
        date: "Future",
        page_size: 5
    };
    EVDB.API.call("/events/search", oArgs, function (oData) {
        showResults(oData);
    });
    function showResults(oData) {
        $('.table').find('tbody').empty();
        for (var i = 0; i < oData.events.event.length; i++) {

            $('.table').append(
           //   '<tr><td>'+"<img src=" +oData.events.event[i].image.medium.url+ ">"+'</td>'+
             '<tr><td>' + oData.events.event[i].title + '</td>' +
             '<td>' + oData.events.event[i].modified + '</td>' +
             '<td>' + oData.events.event[i].venue_name + '</td>' +
             '<td>' + oData.events.event[i].venue_address + '</td></tr>')
        }
    }
}
