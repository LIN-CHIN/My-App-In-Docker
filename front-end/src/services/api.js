import axios from 'axios'

// 定義API URL常數
const API_URL = 'http://localhost/api'

// 定義一個API服務物件
const ApiService = {

  // 呼叫"users"API
  getUsers() {
    return axios.get(`${API_URL}/user`)
  }
}

export default ApiService
