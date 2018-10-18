let http = require('http');

http.createServer(
	function(req, res) {
		res.end("<h1>Hello JS!</h1>");
	}
).listen(3333);