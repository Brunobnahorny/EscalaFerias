import Vue from 'vue';
import Router from 'vue-router';
import Home from './components/Home/Home';
import Login from './components/Login/Login';
import Lojas from './components/Lojas/Lojas';
import LojaDetalhe from './components/Lojas/LojaDetalhe';
import EmployeeDetails from './components/Employees/EmployeeDetails';


Vue.use(Router);

export default new Router({
    routes: [
        {
            path: '/',
            nome: 'Home',
            component: Home
        },
        {
            path: '/Login',
            nome: 'Login',
            component: Login
        },
        {
            path: '/Lojas',
            nome: 'Lojas',
            component: Lojas
        },
        {
            path: '/LojaDetalhe',
            nome: 'LojaDetalhe',
            component: LojaDetalhe
        },
        {
            path: '/Lojadetalhe/:Loja_id',
            nome: 'LojaDetalhe',
            component: LojaDetalhe
        },
        {
            path: '/EmployeeDetails',
            nome: 'EmployeeDetails',
            component: EmployeeDetails
        },
        {
            path: '/EmployeeDetails/:Employee_id',
            nome: 'EmployeeDetails',
            component: EmployeeDetails
        }
    ]
})