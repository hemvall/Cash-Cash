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
    path: '/clients',
    name: 'clients',
    component: function () {
      return import( '../views/Assistant/Clients/Client.vue')
    }
  },
  {
    path: '/contrats',
    name: 'contrats',
    component: function () {
      return import( '../views/Assistant/Contrats/ContratsPage.vue')
    }
  },
  {
    path: '/techniciens',
    name: 'techniciens',
    component: function () {
      return import( '../views/Technicien/TechniciensPage.vue')
    }
  },
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
