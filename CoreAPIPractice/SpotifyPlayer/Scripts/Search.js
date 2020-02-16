function DoSearch() {
    if (!window.refresh_token) {
        GetToken().done(function (token) {
            window.refresh_token = token.refresh_token;
            $.ajax({
                url: 'https://api.spotify.com/v1/search?q=electronic&type=track',
                method: 'GET',
                beforeSend: function (xhr) {
                    xhr.setRequestHeader('Authorization', 'Bearer ' + token.access_token);
                }
            }).done(function (data) {
                $("#searchResult").html(JSON.stringify(data));
            });
        });
    }
    else {
        GetRefreshToken().done(function (token) {
            if (token.refresh_token)
            window.refresh_token = token.refresh_token;
            $.ajax({
                url: 'https://api.spotify.com/v1/search?q=electronic&type=track',
                method: 'GET',
                beforeSend: function (xhr) {
                    xhr.setRequestHeader('Authorization', 'Bearer ' + token.access_token);
                }
            }).done(function (data) {
                $("#searchResult").html(JSON.stringify(data));
            });
        });
    }
 }