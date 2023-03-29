FROM node:latest
RUN mkdir /app
WORKDIR /app
COPY /front-end .
RUN npm install
EXPOSE 8080
CMD ["npm", "run", "serve"]
