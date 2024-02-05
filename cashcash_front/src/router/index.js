import { createRouter, createWebHistory } from 'vue-router'

const routes = [
  {
    path: '/',
    name: 'home',
    component: function () {
      return import( '../views/Home/HomePage.vue')
    }
  },
  {
    path: '/technicien/:userId/interventions',
    name: 'technicienInterventions',
    component: function () {
      return import( '../views/Technicien/Interventions/InterventionsPage.vue')
    }
  },
  {
    path: '/interventions',
    name: 'interventions',
    component: function () {
      return import( '../views/Assistant/Interventions/InterventionsPage.vue')
    }
  },
  {
    path:'/Clients',
    name: 'clients',
    component: function (){
      return import('../views/Client/Client.vue')
    }
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
