<template>
  <div>
    <titulo titulo="Lista de Lojas" />
    <div class="content">
      <table>
        <thead>
          <tr>
            <th style="width: 15%">Loja</th>
            <th>Localização</th>
            <th><div class="divemp">Empregados</div> Data de Admissão</th>
            <!--<th>Data Admissão</th> -->
          </tr>
        </thead>
        <tbody>
          <tr v-for="(item, index) in stores" :key="index">
            <router-link
              :to="'/StoreDetails/' + item.storeId"
              tag="td" class=" clickable txt-center">
              <strong>{{item.storeId}} <br> {{item.name}}</strong>
            </router-link>
            <td class="txt-center">
              <iframe
                :src="'https://maps.google.com/maps?q=\''+item.location+'&hl=pt-br&z=14&amp;output=embed'"
                width="380"
                height="300"
                frameborder="0"
                style="border:0;"
                allowfullscreen
                aria-hidden="false"
                tabindex="0"
              ></iframe>
              <br />
              <small class="txt-center">{{item.location}}</small>
            </td>

            <td  class="txt-left">
              <div v-for="(employees, eindex) in item.employees" :key="eindex">
                <router-link
              :to="'/EmployeeDetails/' + employees.employeeId"
              tag="div"  class="divemp clickable">
                <strong>{{employees.name}}</strong>
                </router-link>
                
                {{employees.dateAdmission.slice(8,10)+'/'+employees.dateAdmission.slice(5,7)+'/'+employees.dateAdmission.slice(0,4)}}
                
                <br><br>
              </div>
            </td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
</template>

<script>
import Titulo from "../../components/_shared/_titulo";
import storesjson from "../../components/Data/stores.json";

export default {
  components: {
    Titulo
  },
  data() {
    return {
      stores: this.StoreDateCorrect(storesjson)
    };
  },
  /*
  created() { //.NET Core + Entity Framework Back-End
      this.$http
        .get("http://localhost:5000/api/storedetails/")
        .then(res => res.json())
        .then(res => (this.stores = this.StoreDateCorrect(res)));
  },
  */  
  methods: {
    StoreDateCorrect: function(store) {
      if (store) {
        for (const key in store.employees) {
          store.employees[key].dateAdmission = store.employees[
            key
          ].dateAdmission.slice(0, 10);

          for (const key2 in store.employees[key].vacations) {
            store.employees[key].vacations[key2].initDate = store.employees[
              key
            ].vacations[key2].initDate.slice(0, 10);
          }
        }
        return store;
      }
    }
  }
};
</script>

<style scoped>
table {
  width: 100%;
  border-collapse: collapse;
  overflow: hidden;
  box-shadow: 0 0 20px var(--cor-terciaria);
}

td {
  padding: 15px;
  color: var(--cor-cinza2);
  background-image: linear-gradient(to top, var(--cor-secundaria), white);
}
th {
  min-width: 100px;
  text-align: left;
  padding: 15px;
  color: #fff;
}

thead {
  background-image: linear-gradient(
    45deg,
    var(--cor-principal2),
    var(--cor-secundaria)
  );
}

tbody {
  color: var(--cor-cinza2);
}
.txt-right {
  text-align: right;
  box-shadow: -2px 2px 4px white inset;
}
.txt-top {
  vertical-align: top;
}
.txt-center {
  text-align: center;
}
.txt-left {
  text-align: left;
  width: 100%;
}
.divemp {
  display: inline-flex;
  min-width: 150px;
  width: 20%;
}
</style>