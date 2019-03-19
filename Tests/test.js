var expect  = require('chai').expect;
var request = require('request');

describe('/api/ping', function () {
    it('Ping is connected to Pong', function(done) {
        request('http://localhost:5000/api/ping' , function(error, response, body) {
            expect(body).to.equal('Ping Pong');
            done();
        });
    });
});