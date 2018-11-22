FROM node:7
WORKDIR /app
COPY package.json /app
RUN npm install
COPY . /app
RUN npm install -g newman
CMD newman run https://raw.githubusercontent.com/swizkon/roblang-tdd-workshop/master/votee/Haxx.postman_collection -n 1000

EXPOSE 8081
