import axios from 'axios'

export const http = axios.create({
  baseURL: 'api/organismo/',
  timeout: 25000
})
