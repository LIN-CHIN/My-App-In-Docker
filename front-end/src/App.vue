<template>
  <img alt="Vue logo" src="./assets/logo.png">
  <HelloWorld msg="Welcome to Your Vue.js App"/>
</template>

<script>
import HelloWorld from './components/HelloWorld.vue'
import ApiService from './services/api'

export default {
  name: 'App',
  components: {
    HelloWorld
  },
  created() {
    ApiService.getUsers()
      .then(response => {
        // API回應成功，處理回應資料
        console.log(response.data)
      })
      .catch(error => {
        // API回應錯誤，處理錯誤
        console.error(error)
      })
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
