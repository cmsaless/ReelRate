$(document).ready(function () {
    var input = $("#search-bar");
    input.keypress((event) => {
        if (event.which == 13) {
            event.preventDefault();
            $("#search-button").click();
        }
    });
});

function search(list_id) {

    var query = $("#search-bar").val();
    query = query.replace(' ', '+');

    const Http = new XMLHttpRequest();
    var url = 'https://api.themoviedb.org/3/search/movie?api_key=96176cdd887d42653dce0c4c94f56705&query=' + query + '&page=1'
    Http.responseType = 'json';
    Http.open("GET", url, true);
    Http.send();

    Http.onreadystatechange = (e) => {

        if (Http.readyState == 4 && Http.status == 200) {

            var json = Http.response
            $("#results").empty()

            for (i = 0; i < json['results'].length; ++i) {

                var current_res = json['results'][i]

                var poster = current_res['poster_path']
                var poster_url
                if (poster != null) {
                    poster_url = 'https://image.tmdb.org/t/p/w185/' + poster
                } else {
                    poster_url = "#"
                }

                var title = current_res['title']
                var year = current_res['release_date'].substr(0, 4)
                var tmdb_id = current_res['id']
                var description = current_res['overview']

                $('#results').append(
                    "<tr>" +
                    "<td>" + "<img src='" + poster_url + "' style='width:50px' />" + "</td>" +
                    "<td>" + "<p class='movie-info'>" + title + "</p>" + "</td>" +
                    "<td>" + "<p class='movie-info'>" + year + "</p>" + "</td>" +
                    "<td>" +
                    "<form action='/MovieLists/Add' method='post' id='Add-Movie-Form"+i+"'>" +
                    '<input type="hidden" name="list_id" value="' + list_id + '">' +
                    '<input type="hidden" name="Movie.TMDB_ID" value="' + tmdb_id + '">' +
                    '<input type="hidden" name="Movie.Title" value="' + title + '">' +
                    //'<input type="hidden" name="Movie.Description" value="' + cleanString(description) + '">' +
                    '<input type="hidden" name="Movie.Year" value="' + year + '">' +
                    '<input type="hidden" name="Movie.Poster" value="' + poster_url + '">' +
                    '<input type="button" class="btn btn-primary" value="Add" id="submit-button" onclick="postForm(this, '+i+')">' +
                    '</form>' +
                    "</td>" +
                    "</tr>")
            }
        }

    }

}

function postForm(button, i) {

    $.ajax({
        url: '/MovieLists/Add',
        type: 'post',
        data: $('#Add-Movie-Form' + i).serialize()
    });

    var btn = $(button)
    btn.attr("value", "Added!")
    btn.removeClass("btn-primary")
    btn.addClass("btn-default")
    btn.addClass("disabled")
}

function cleanString(string_) {
    console.log("unclean: " + string_)
    var retval = string_.replace(/\"/g, '&quot')
    console.log("cleaned: " + retval)

    return retval;
    //return string_;
}