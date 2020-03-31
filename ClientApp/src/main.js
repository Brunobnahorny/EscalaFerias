import Vue from 'vue'
//import VueResource from 'vue-resource' 
import router from './router.js'
import App from './App.vue'
import moment from 'moment'


Vue.config.productionTip = false
//Vue.use(VueResource)



new Vue({
  router, moment,
  render: h => h(App),
}).$mount('#app')
