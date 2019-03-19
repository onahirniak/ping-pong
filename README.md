# Ping-Pong
It's two very high load services.

## Ping
Python service that makes HTTP calls to Pong and combines answer with 'Ping ' prefix

## Pong
.NET Core service with only one GET endpoing that returns 'Pong'

## Tests
NodeJS tests based on Mocka and Chai. There is only one test which makes http call to Ping and verify response.
