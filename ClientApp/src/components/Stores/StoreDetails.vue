<template>
  <div>
    <titulo :titulo="'Detalhe Loja '+ stores.name" />
    <div class="content">
      <table>
        <thead>
          <tr>
            <th>01</th>
            <th>02</th>
            <th>03</th>
            <th>04</th>
            <th>05</th>
            <th>06</th>
            <th>07</th>
            <th>08</th>
            <th>09</th>
            <th>10</th>
            <th>11</th>
            <th>12</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td colspan="12" class="progressBar">
              <span
                style="margin-left: 16px; display: block; text-align: left;"
              >{{stores.storeId + ' - ' + stores.name}}</span>
              <div id="myProgress">
                <div
                  v-for="(employee, index) in stores.employees"
                  :key="index"
                  class="lineProgress"
                >
                  <router-link tag="div" :to="'/EmployeeDetails/' + employee.employeeId" class="empName clickable">{{employee.name}}</router-link>
                  <div v-for="(vacation, index2) in employee.vacations" :key="index2">
                    <div
                      v-if="vacation.initDate.slice(0,4) == 2020"
                      v-on:click="EditaVacation"
                      class="myBar clickable tooltip"
                      :style="'left: ' + CalcBar(vacation)[0] + '%; width: ' + CalcBar(vacation)[1]+'%'"
                    >
                      <span class="tooltiptext">
                        <label for="vacationinit">Data saída:</label>
                        <input
                          v-model="vacation.initDate"
                          type="date"
                          name="vacationinit"
                          style="width: 175px"
                        />
                        Data volta:
                        {{CalcDataVolta(vacation.initDate, vacation.vacationDays)}}
                        <label
                          for="vacationdays"
                        >
                          Quantidade de dias:
                          <input
                            v-model="vacation.vacationDays"
                            type="number"
                            name="vacationdays"
                          />
                        </label>
                      </span>
                    </div>
                  </div>
                </div>
              </div>
            </td>
          </tr>
        </tbody>
      </table>
      <button @click="SaveChanges">Salvar alterações</button>
    </div>
  </div>
</template>

<script>
import Titulo from "../../components/_shared/_titulo";
import stmonica from "../../components/Data/stmonica.json";

export default {
  components: {
    Titulo
  },
  data() {
    return {
      actualYear: new Date().getFullYear(),
      //storeid: this.$route.params.Store_id,
      stores: this.StoreDateCorrect(stmonica)
    };
  },
  /*
  created() {
    if (this.storeid) {
      this.$http
        .get("http://localhost:5000/api/storedetails/" + this.storeid)
        .then(res => res.json())
        .then(res => (this.stores = this.StoreDateCorrect(res)));
    }
  },
  */
  methods: {
    CalcBar: function(vacation) {
      var lBar = 0;
      var wBar = 0;
      var mes = vacation.initDate.slice(5, 7);
      var dia = vacation.initDate.slice(8, 10);
      lBar = 825 * (mes - 1);
      lBar += 27.5 * dia;
      lBar /= 100;
      wBar = vacation.vacationDays * 0.278;

      return [lBar, wBar];
    },
    CalcDataVolta: function(date, vacationDays) {
      var result = new Date(date);
      result.setDate(result.getDate() + vacationDays);
      return result.toLocaleDateString();
    },
    EditaVacation: function(e) {
      this.editing = true;
      if (e.toElement.className == "myBar clickable tooltip") {
        e.target.children[0].children[1].focus();
      }
    },
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
    },
    SaveChanges: function() {
      /*
      this.$http
        .put(
          "http://localhost:5000/api/storedetails/" + this.storeid,
          this.stores
        )
        .then(res => res.json())
        .then(res => (this.store = this.StoreDateCorrect(res)));
        */
       alert('Test project, not actually saved...');
    }
  }
};
</script>

<style scoped>
table {
  text-align: center;
  width: 100%;
  border-collapse: collapse;
  box-shadow: 0 0 20px var(--cor-terciaria);
}

td {
  padding: 6px;
  color: var(--cor-cinza2);
  background-image: linear-gradient(to top, var(--cor-secundaria), white);
}
.progressBar {
  padding: 0px;
}

th {
  text-align: left;
  padding: 15px 0px;
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
#myProgress {
  vertical-align: middle;
  border-radius: 25px;
  position: relative;
  float: left;
  margin-top: 0px;
  margin-left: 0px;
  width: 100%;
  background-color: var(--cor-terciaria);
}

.myBar {
  position: relative;
  z-index: 2;
  border-radius: 1em;
  height: 1.5em;
  background-color: var(--cor-principal2);
  opacity: 50%;
}
.lineProgress {
  box-shadow: 0 0 1px #fff;
  padding-top: 2px;
  padding-bottom: 2px;
  height: 1.5em;
}
.empName {
  position: absolute;
  width: 100%;
  margin-top: 3px;
  height: 1.5em;
  z-index: 1;
  color: #fff;
  text-shadow: 1px 1px 4px #000;
}

.tooltip .tooltiptext {
  z-index: 5;
  visibility: hidden;
  width: 180px;
  background-color: black;
  color: #fff;
  text-align: center;
  border-radius: 6px;
  padding: 5px 0;
  position: absolute;
  z-index: 1;
  bottom: 150%;
  left: 20%;
  margin-left: -60px;
}

.tooltip .tooltiptext::after {
  content: "";
  position: absolute;
  top: 100%;
  left: 50%;
  margin-left: -5px;
  border-width: 5px;
  border-style: solid;
  border-color: black transparent transparent transparent;
}

.tooltip:hover .tooltiptext {
  visibility: visible;
}
.tooltip:focus-within .tooltiptext:focus-within {
  visibility: visible;
  opacity: 90%;
}
.myBar:focus-within .myBartext:focus-within {
  visibility: visible;
  opacity: 90%;
}
.myBar:hover {
  opacity: 90%;
}

button {
  outline: none;
  border: none;
  float: right;
  margin-top: 5px;
  padding: 8px 15px 8px 15px;
  background-color: var(--cor-clara);
  background-image: linear-gradient(
    45deg,
    var(--cor-secundaria),
    var(--cor-clara)
  );
  color: var(--cor-cinza);
  box-shadow: 1px 1px 4px black;
  border-radius: 3px;
}
button:hover {
  background: #ea7b00;
  color: #fff;
}
button:active {
  transition: 200ms;
  background-image: none;
  box-shadow: 0px 0px 0px;
}
</style>