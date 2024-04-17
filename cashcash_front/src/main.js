import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import { createStore } from 'vuex'
import vue3ToPdf from 'vue3-to-pdf'

const store = createStore({
  state () {
    return {
      userConnecte: false,
      userFonction: 'Assistant',
      user: {}
    }
  },
  mutations: {
    LogUser (state, user) {
      this.userConnecte = true;
      this.userFonction = user;
    },

    changeUserFonction (state, uF) {
      this.userFonction = uF;
    },
  }
})

const app = createApp(App);
// dev
app.config.globalProperties.$api = "https://localhost:7000";
// prod
// app.config.globalProperties.$api = 'https://api.heracle.me'

app.use(router).use(store).use(vue3ToPdf).mount("#app");