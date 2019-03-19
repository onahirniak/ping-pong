FROM node:7
# Copy the test files
COPY . /tests
WORKDIR /tests
# Override the NODE_ENV environment variable to 'dev', in order to get required test packages
ENV NODE_ENV dev
# 1. Get test packages; AND
# 2. Install our test framework - mocha
RUN npm update && \
    npm install -g mocha
# Override the command, to run the test instead of the application
CMD ["mocha", "test.js", "--reporter", "spec"]