<template>
    <div class="lighten-2">
      <v-container>
        <template v-for="(value,key,index) in std_cat" >
          <div :key="index" v-if="cards.includes(key)">
            <v-row :key="index">
              <v-col
                :key="index"
                class="mt-2"
                cols="12"
                v-show="value.length != 0"
              >
                <h2>{{ key }}</h2>
              </v-col>
            </v-row>
            <v-row v-show="value.length != 0" :key="index">
                <v-col
                  v-for="(stu,idx) in value"
                  :key="`${key}${idx}`"
                  cols="2"
                >
                  <v-sheet>
                    <Student :stu="stu" />
                  </v-sheet>
                </v-col>
            </v-row>
          </div>
          <div :key="index" v-if="key == 'Past Members'">
            <v-row>
              <div class="mt-2 mb-2">

                <h2 class="mb-4">{{ key }}</h2>
                <p v-for="(pastlab,idx) in value" :key="`${key}${idx}`" style="line-height:13px; ">
                  <a v-if="pastlab['homepage'] != None" :href="pastlab['homepage']">
                    <b>
                      {{pastlab['name']}}
                    </b>
                  </a>
                  <b v-else>
                    {{pastlab['name']}}
                  </b>
                  <span>{{pastlab['year']}}</span>
                  <!-- <i>{{pastlab['affiliation']}}</i> -->
                </p>
              </div>
            </v-row>
          </div>
          <div :key="index" v-if="key == 'Collaborators'">
            <v-row>
              <div class="mt-2 mb-2">

                <h2 class="mb-4">{{ key }}</h2>
                <p v-for="(collab,idx) in value" :key="`${key}${idx}`" style="line-height:13px">
                  <a v-if="collab['homepage'] != None" :href="collab['homepage']">
                    <b>
                      {{collab['name']}}
                    </b>
                  </a>
                  <b v-else>
                    {{collab['name']}}
                  </b>
                  <i>{{collab['affiliation']}}</i>
                </p>
              </div>
            </v-row>
          </div>
        </template>
      </v-container>
    </div>
</template>

<script>
import Student from '@/components/Student'

export default {
  props: ['memberData'],
  components: {
    Student
  },
  data: () => ({
    std_cat: {},
    cards: ['Master', 'Undergraduate', 'Ph.D.'] // 这里可以加入 Ph.D.以及 Past Members
  }),
  mounted () {
    this.std_cat = this.memberData
  }
}
</script>

<style>

</style>
