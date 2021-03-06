function swapStyleSheet(sheet){

	document.getElementById('pagestyle').setAttribute('href', sheet);
	
	
}

var style_cookie_name = "style" ;
var style_cookie_duration = 30 ;


function set_style_from_cookie()
{
  var sheet = get_cookie(style_cookie_name);
  if (css_title.length) {
    swapStyleSheet(sheet);
  }
}


function set_cookie ( cookie_name, cookie_value, lifespan_in_days, valid_domain )
{
    
    var domain_string = valid_domain ? ("; domain=" + valid_domain) : '' ;
    document.cookie = cookie_name + "=" + encodeURIComponent( cookie_value )+"; max-age=" + 60*60*24*lifespan_in_days+"; path=/" + domain_string ;
}


function get_cookie(cookie_name)
{
    
    var cookie_string = document.cookie ;
    if (cookie_string.length != 0) {
        var cookie_value = cookie_string.match (
                        '(^|;)[\s]*' +
                        cookie_name +
                        '=([^;]*)' );
        return decodeURIComponent ( cookie_value[2] ) ;
    }
    return '' ;
}
