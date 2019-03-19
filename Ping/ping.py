from flask import Flask
import requests
app = Flask(__name__)

@app.route('/api/ping')
def ping():
    response = requests.get("http://pong:5000/api/pong")

    result = 'Ping ' + response.text;

    print(result)

    return result

if __name__ == '__main__':
    app.run(debug=True,host='0.0.0.0')