docker-compose up -d --build
cd tests
docker build -t tests .
docker run --network host --name tests-container tests 
docker rm tests-container 
cd ..
docker-compose down
docker-compose rm